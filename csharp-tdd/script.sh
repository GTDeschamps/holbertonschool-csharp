#!/usr/bin/env bash
# Check if necessary arguments are provided
if [ $# -lt 2 ]; then
  echo "Usage: $0 <task_name> <namespace>"
  exit 1
fi
# Extract arguments
task_name=$1
namespace=$2
# Create task directory
mkdir $task_name
cd $task_name
# Create solution file
dotnet new sln
# Create class library
class_lib_name="${namespace}"
mkdir $class_lib_name
cd $class_lib_name
dotnet new classlib
mv Class1.cs $namespace.cs
sed -i '/<\/PropertyGroup>/i \ \ \ \ <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>' "${namespace}.csproj"
cd ..
# Add class library to solution
dotnet sln add ${class_lib_name}/${namespace}.csproj
# Create test project
test_lib_name="${namespace}.Tests"
mkdir $test_lib_name
cd $test_lib_name
dotnet new nunit
mv UnitTest1.cs ${namespace}.Tests.cs
sed -i "s/namespace Tests/namespace $namespace.Tests/" ${namespace}.Tests.cs
dotnet add reference ../${class_lib_name}/${namespace}.csproj
cd ..
# Add reference to class library in test project
# Add test project to solution
dotnet sln add ${test_lib_name}/${namespace}.Tests.csproj
# Return to root directory
cd ..
