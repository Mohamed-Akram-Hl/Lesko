
@echo off

REM Vars
set "SLNDIR=%~dp0src"

REM Restore + Build
dotnet build "%SLNDIR%\lki" --nologo || exit /b

REM Run
dotnet run --project "%SLNDIR%\lki" --no-build