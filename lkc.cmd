@echo off

REM Vars
set "SLNDIR=%~dp0src"

REM Restore + Build
dotnet build "%SLNDIR%\lkc" --nologo || exit /b

REM Run
dotnet run --project "%SLNDIR%\lkc" --no-build -- %*