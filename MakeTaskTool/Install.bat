@echo off

reg add "HKEY_CLASSES_ROOT\DesktopBackground\Shell\MakeTaskTool" /d "タスクを作成する" /f
reg add "HKEY_CLASSES_ROOT\DesktopBackground\Shell\MakeTaskTool" /v "Icon" /d "%~dp0MakeTaskTool.ico" /f
reg add "HKEY_CLASSES_ROOT\DesktopBackground\Shell\MakeTaskTool" /v "Position" /d "Middle" /f
reg add "HKEY_CLASSES_ROOT\DesktopBackground\Shell\MakeTaskTool\Command" /d "%~dp0MakeTaskTool.exe" /f

echo インストールが完了しました。
pause