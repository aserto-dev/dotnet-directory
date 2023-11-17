//go:build mage
// +build mage

package main

import (
	"fmt"
	"os"
	"path"
	"path/filepath"

	"github.com/aserto-dev/mage-loot/buf"
	"github.com/aserto-dev/mage-loot/common"
	"github.com/aserto-dev/mage-loot/deps"
	"github.com/aserto-dev/mage-loot/mage"
)

const (
	grpcGatewayBufImage   = "buf.build/grpc-ecosystem/grpc-gateway"
	asertoBufImage        = "buf.build/aserto-dev/directory"
	protoValidateBufImage = "buf.build/bufbuild/protovalidate"
)

func All() error {
	Deps()
	err := Clean()
	if err != nil {
		return err
	}
	return Generate()
}

// install required dependencies.
func Deps() {
	deps.GetAllDeps()
}

// Generate code
func Generate() error {
	bufImages := []string{
		grpcGatewayBufImage,
		protoValidateBufImage,
		asertoBufImage,
	}

	for _, bufImage := range bufImages {
		buffImgWithTag, err := addLatestTag(bufImage)
		if err != nil {
			return err
		}

		err = gen(buffImgWithTag)
		if err != nil {
			return err
		}
	}

	return nil
}

// Generates from a dev build.
func GenerateDev() error {
	err := BuildDev()
	if err != nil {
		return err
	}

	fileSources := filepath.Join(getProtoRepo(), "proto#format=dir")

	return gen(fileSources)
}

// Builds the aserto proto image
func BuildDev() error {
	return mage.RunDirs(path.Join(getProtoRepo(), "magefiles"), getProtoRepo(), mage.AddArg("build"))
}

// Removes generated files
func Clean() error {
	err := os.RemoveAll("build")
	if err != nil {
		return err
	}

	return os.RemoveAll("generated")

}

func Bump(next string) error {
	nextVersion, err := common.NextVersion(next)
	if err != nil {
		return err
	}
	fmt.Println("Bumping version to", nextVersion)

	fi, err := os.OpenFile("VERSION", os.O_RDWR|os.O_CREATE, 0755)
	if err != nil {
		return err
	}
	defer fi.Close()

	_, err = fi.WriteString(nextVersion)
	return err
}

func getProtoRepo() string {
	protoRepo := os.Getenv("PROTO_REPO")
	if protoRepo == "" {
		protoRepo = "../pb-directory"
	}
	return protoRepo
}

// Builds the aserto proto image
func addLatestTag(bufImage string) (string, error) {
	tag, err := buf.GetLatestTag(bufImage)
	if err != nil {
		return "", err
	} else {
		bufImage = fmt.Sprintf("%s:%s", bufImage, tag.Name)
	}

	return bufImage, nil
}

func gen(bufImage string) error {
	err := buf.Run(
		buf.AddArg("generate"),
		buf.AddArg("--include-imports"),
		buf.AddArg("--template"),
		buf.AddArg(filepath.Join("buf", "buf.gen.yaml")),
		buf.AddArg(bufImage),
	)

	return err
}
