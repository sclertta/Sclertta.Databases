#!/bin/bash

SCRIPT_DIR=$(dirname "$0")/
ARTIFACTS_DIR=${SCRIPT_DIR}../artifacts/

Source=$1
ApiKey=$2

dotnet nuget push ${ARTIFACTS_DIR}*.nupkg --source $Source --api-key $ApiKey
