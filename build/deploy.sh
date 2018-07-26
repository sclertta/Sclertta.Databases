#!/bin/bash

SCRIPT_DIR=$(dirname "$0")/
ARTIFACTS_DIR=${SCRIPT_DIR}../artifacts/

Source=$1
ApiKey=$2

for filename in ${ARTIFACTS_DIR}*.nupkg; do
    dotnet nuget push $filename --source $Source --api-key $ApiKey    
done
