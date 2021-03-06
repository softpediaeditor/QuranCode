RMDIR /S /Q NET2
"%PROGRAMFILES%\7-Zip\7z.exe" x Tools\NET2.zip
echo .csproj > exclude.txt
XCOPY /E /EXCLUDE:exclude.txt Globals\*.* NET2\Globals\
XCOPY /E /EXCLUDE:exclude.txt Utilities\*.* NET2\Utilities\
XCOPY /E /EXCLUDE:exclude.txt Model\*.* NET2\Model\
XCOPY /E /EXCLUDE:exclude.txt DataAccess\*.* NET2\DataAccess\
XCOPY /E /EXCLUDE:exclude.txt Server\*.* NET2\Server\
XCOPY /E /EXCLUDE:exclude.txt Client\*.* NET2\Client\
XCOPY /E /EXCLUDE:exclude.txt Research\*.* NET2\Research\
XCOPY /E /EXCLUDE:exclude.txt QuranCode\*.* NET2\QuranCode\
XCOPY /E /EXCLUDE:exclude.txt PrimeCalculator\*.* NET2\PrimeCalculator\
XCOPY /E /EXCLUDE:exclude.txt QuranLab\*.* NET2\QuranLab\
XCOPY /E /EXCLUDE:exclude.txt InitialLetters\*.* NET2\InitialLetters\
XCOPY /E /EXCLUDE:exclude.txt Composites\*.* NET2\Composites\
XCOPY /E /EXCLUDE:exclude.txt Numbers\*.* NET2\Numbers\

DEL exclude.txt
Tools\Replace\bin\Release\Replace.exe NET2 *.Designer.cs ((System.ComponentModel.ISupportInitialize) //((System.ComponentModel.ISupportInitialize)
CALL Version.bat
CD NET2
CALL Version.bat
CD ..