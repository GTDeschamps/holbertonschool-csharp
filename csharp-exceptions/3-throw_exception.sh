#!/usr/bin/env bash
dotnet new console -o 3-throw_exception
dotnet build 3-throw_exception
cd 3-throw_exception
dotnet run
