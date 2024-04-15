#!/usr/bin/env bash
dotnet new console -o 1-element_at
dotnet build 1-element_at
cd 1-element_at
dotnet run
