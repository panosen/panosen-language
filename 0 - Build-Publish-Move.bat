@echo off

dotnet restore

dotnet build --no-restore -c Release

dotnet nuget push Panosen.Language\bin\Release\Panosen.Language.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.Language.CSharp\bin\Release\Panosen.Language.CSharp.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.Language.Java\bin\Release\Panosen.Language.Java.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.Language.Mysql\bin\Release\Panosen.Language.Mysql.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.Language.Typescript\bin\Release\Panosen.Language.Typescript.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.Language.Vue\bin\Release\Panosen.Language.Vue.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate

move /Y Panosen.Language\bin\Release\Panosen.Language.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.CSharp\bin\Release\Panosen.Language.CSharp.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Java\bin\Release\Panosen.Language.Java.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Mysql\bin\Release\Panosen.Language.Mysql.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Typescript\bin\Release\Panosen.Language.Typescript.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Vue\bin\Release\Panosen.Language.Vue.*.nupkg D:\LocalSavoryNuget\

pause