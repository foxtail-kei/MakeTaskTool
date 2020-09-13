@echo off

reg delete "HKEY_CLASSES_ROOT\DesktopBackground\Shell\MakeTaskTool" /f

echo アンインストールが完了しました。
pause