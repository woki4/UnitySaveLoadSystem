using System.IO;
using UnityEngine;

namespace Woki4.SaveLoad
{
    public class JsonSaveLoad
    {
        public static string GetPath(string fileName)
        {
            string filePath = Application.persistentDataPath + $"/{fileName}.json";
            return filePath;
        }

        public static void SaveData<T>(T classType, string fileName = "CurrentData")
        {
            string jsonString = JsonUtility.ToJson(classType);
            FileStream fileStream = new FileStream(GetPath(fileName), FileMode.Create);

            using StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(jsonString);
        }

        public static T LoadData<T>(string fileName = "CurrentData")
        {
            string dataAsJson = "";
            string path = GetPath(fileName);
            
            if (File.Exists(path))
            {
                using(StreamReader streamReader = new StreamReader(path))
                {
                    dataAsJson = streamReader.ReadToEnd();
                }
            }
            
            T currentItem = JsonUtility.FromJson<T>(dataAsJson);
            
            return currentItem;
        }

        public static void DeleteFile(string fileName)
        {
            string path = GetPath(fileName);
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
