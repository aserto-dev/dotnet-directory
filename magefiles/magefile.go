//go:build mage
// +build mage

package main

import (
	"fmt"
	"os"
	"path"
	"path/filepath"
	"strings"

	"github.com/aserto-dev/mage-loot/buf"
	"github.com/aserto-dev/mage-loot/common"
	"github.com/aserto-dev/mage-loot/deps"
	"github.com/aserto-dev/mage-loot/dotnet/dotnetbuild"
	"github.com/aserto-dev/mage-loot/fsutil"
	"github.com/aserto-dev/mage-loot/mage"
	"github.com/magefile/mage/sh"
	"github.com/pkg/errors"
)

func init() {
	os.Setenv("GO_VERSION", "1.19")
	os.Setenv("GOPRIVATE", "github.com/aserto-dev")
}

func All() error {
	Deps()
	err := Clean()
	if err != nil {
		return err
	}
	err = Generate()
	if err != nil {
		return err
	}
	return Build()

}

// install required dependencies.
func Deps() {
	deps.GetAllDeps()
}

func Generate() error {
	bufImage := "buf.build/aserto-dev/directory"

	tag, err := buf.GetLatestTag(bufImage)
	if err != nil {
		fmt.Printf("Could not retrieve tags, using latest: %s\n", err)
	} else {
		bufImage = fmt.Sprintf("%s:%s", bufImage, tag.Name)
	}

	err = gen(bufImage)
	if err != nil {
		return err
	}
	// ignore errors if no cleanup needed
	sh.RunV("./cleanup.sh")
	return nil
}

// Generates from a dev build.
func GenerateDev() error {
	err := BuildDev()
	if err != nil {
		return err
	}

	fileSources := filepath.Join(getProtoRepo(), "proto#format=dir")

	err = gen(fileSources)
	if err != nil {
		return err
	}

	return sh.RunV("./cleanup.sh")
}

// Builds the aserto proto image
func BuildDev() error {
	return mage.RunDirs(path.Join(getProtoRepo(), "magefiles"), getProtoRepo(), mage.AddArg("build"))
}

func getProtoRepo() string {
	protoRepo := os.Getenv("PROTO_REPO")
	if protoRepo == "" {
		protoRepo = "../pb-directory"
	}
	return protoRepo
}

// Generate the code
func gen(fileSources string) error {

	bufExportDir := filepath.Join(deps.ExtTmpDir(), "export")
	defer os.RemoveAll(bufExportDir)

	directoryPatterns := []string{
		filepath.Join(bufExportDir, "aserto", "directory", "**", "*.proto"),
	}

	err := os.RemoveAll(bufExportDir)
	if err != nil {
		return err
	}

	fsutil.EnsureDir(bufExportDir)

	err = buf.Run(
		buf.AddArg("export"),
		buf.AddArg(fileSources),
		buf.AddArg("-o"),
		buf.AddArg(bufExportDir),
	)

	bufGenDir := filepath.Join(deps.ExtTmpDir(), "proto")
	fsutil.EnsureDir(bufGenDir)
	defer os.RemoveAll(bufGenDir)

	for _, fp := range directoryPatterns {
		files, err := fsutil.Glob(fp, "")
		if err != nil {
			return errors.Wrapf(err, "failed to glob %s", fp)
		}

		for _, f := range files {

			genFile := strings.Replace(f, bufExportDir, bufGenDir, -1)
			fsutil.EnsureDir(filepath.Dir(genFile))

			err = os.Rename(f, genFile)
			if err != nil {
				return errors.Wrapf(err, "failed to rename %s", f)
			}
		}
	}

	return dotnetbuild.Run(
		dotnetbuild.Project(filepath.Join(common.WorkDir(), "build", "generate.csproj")),
	)
}

// Builds the Dotnet client projects.
func Build() error {
	return dotnetbuild.Run(
		dotnetbuild.Project(filepath.Join(common.WorkDir(), "build", "generate.csproj")),
	)
}

// Clean generated files
func Clean() error {
	err := os.RemoveAll(filepath.Join("src", "Aserto.Directory.V3.Client.Grpc", "aserto"))
	return err
}
