using UnityEngine;

namespace Woki4.SaveLoad
{
    public class GameDataSaveLoad
    {
        public static GameData GameData;
    
        public static void Load()
        {
            GameData = JsonSaveLoad.LoadData<GameData>(GameData.FileName);
        
            if (GameData == null)
            {
                GameData = new GameData();
            }
            
            Debug.Log($"<color=green>Game Data loaded</color>");
        }
    
        public static void Save()
        {
            JsonSaveLoad.SaveData(GameData, GameData.FileName);
            
            Debug.Log($"<color=blue>Game Data saved</color>");
        }
    }
}
