:: Build standalone .exe
pyinstaller --onefile --windowed --noconsole --clean ModsManager.spec 1> build.log 2>&1
:: Copy built file to release repo
@echo off
if exist ".\dist\ModsManager.exe" (
    xcopy ".\dist\ModsManager.exe" ".\FsModsManager\" /y /c
) else (
    echo ".\dist\ModsManager.exe WAS NOT FOUND"
)

