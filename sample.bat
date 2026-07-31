@echo off
cls

::-------------
:: １行で記述
::-------------
for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -center -size=600,400 -title="１行で記述" -text="オプションを\\n１行で記述した例" -textsize=10 -checkbox="上記内容を承諾します。" -button=1,1 -buttontext="はい","いいえ","閉じる""`) do echo %%s

::---------------------
:: 変数利用による記述
::---------------------
set SIZE=600,400
set TITLE=変数利用による記述
set TEXT=^
オプションを\\n^
変数を利用して記述した例
set TEXTSIZE=10
set CHECKBOX=上記内容を承諾します。
set BUTTON=1,1
set BUTTONTEXT="はい","いいえ","閉じる"

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -center -size=%SIZE% -title="%TITLE%" -text="%TEXT%" -textsize=%TEXTSIZE% -checkbox="%CHECKBOX%" -button=%BUTTON% -buttontext=%BUTTONTEXT%"`) do echo %%s

echo.
pause
exit
