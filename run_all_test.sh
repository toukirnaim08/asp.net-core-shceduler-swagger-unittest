#!/bin/sh
######################################
# This script builds the docker image
######################################

set -e

cd tests/
dotnet test --test-adapter-path:. --logger:xunit