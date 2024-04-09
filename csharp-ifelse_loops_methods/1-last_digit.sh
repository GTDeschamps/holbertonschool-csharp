#!/usr/bin/env bash
dotnet new console -o 1-last_digit
dotnet build 1-last_digit
cd 1-last_digit
dotnet run
