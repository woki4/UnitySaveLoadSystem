# Unity Save-Load system

#### Use `GameData` class for store some data:
```c#
    public class GameData
    {
        public const string FileName = "SaveData";

        public int intForSave = 0;
        public string stringForSave = 0;
        ...
    }
```

#### Use `GameDataSaveLoad` class for save and load:
```c#
    GameDataSaveLoad.Save();
    GameDataSaveLoad.Load();
```
#### Use "Game" tab on top for delete save file:
![Screenshot-223-27-05-23](https://github.com/woki4/UnitySaveLoadSystem/assets/68647775/ca29fa8d-50bd-4914-bbe0-30f534e561ba)
