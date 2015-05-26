#!/bin/bash

mono --runtime=v4.0 .nuget/NuGet.exe install FAKE -Version 3.31.4
mono --runtime=v4.0 tools/FAKE.Core/tools/FAKE.exe build.fsx $@