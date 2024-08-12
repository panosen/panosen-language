@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.Language\bin\Release\Panosen.Language.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.CSharp\bin\Release\Panosen.Language.CSharp.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Java\bin\Release\Panosen.Language.Java.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Mysql\bin\Release\Panosen.Language.Mysql.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Typescript\bin\Release\Panosen.Language.Typescript.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.Language.Vue\bin\Release\Panosen.Language.Vue.*.nupkg D:\LocalSavoryNuget\

pause