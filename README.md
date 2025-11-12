U will get an error here: "System.IO.DirectoryNotFoundException: 'Could not find a part of the path 'C:\Users\user\Downloads\HistoryGame.txt'.'"
```c#
StreamReader Reader = new StreamReader(FilePath)
```
So so just add this file HistoryGame.txt in the right path, u can change the path of the file to the current working directory and this is better
