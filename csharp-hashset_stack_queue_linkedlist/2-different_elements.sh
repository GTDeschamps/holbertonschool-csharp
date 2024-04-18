#!/usr/bin/env bash
dotnet new console -o 2-different_elements
dotnet build 2-different_elements
cd 2-different_elements
dotnet run
