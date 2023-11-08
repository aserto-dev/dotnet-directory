#!/bin/bash

set +e

/usr/bin/grep -rl global::Buf.Validate.ValidateReflection.Descriptor, ./src | xargs -n 1 sed -i 's/global::Buf.Validate.ValidateReflection.Descriptor,//g'
/usr/bin/grep -rl global::Grpc.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor, ./src | xargs -n 1 sed -i 's/global::Grpc.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor,//g'
