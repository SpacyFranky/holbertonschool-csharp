#!/usr/bin/env bash
dotnet new console -n $1
dotnet build $1
dotnet run -p $1
