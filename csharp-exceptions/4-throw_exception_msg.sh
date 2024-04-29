#!/usr/bin/env bash
dotnet new console -o 4-throw_exception_msg
dotnet build 4-throw_exception_msg
cd 4-throw_exception_msg
dotnet run
