#!/usr/bin/env bash
dotnet new console -o MyMath
dotnet new console -o MyMath.Tests
dotnet build MyMath
dotnet build MyMath.Tests
cd MyMath
cd MyMath.Tests
dotnet run
