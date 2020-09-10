#!/usr/bin/env bash
dotnet new console -n $1
dotnet build $1
mv ./$1/Program.cs ./$1/$1.cs
#sed -i '3, 4d; 12d' ./$1/$1.cs
#sed -i -e 's/\\[t]/ /g' ./$1/$1.cs
