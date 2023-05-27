#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Woki4.SaveLoad
{
    public class DeleteSaveFileWindow : MonoBehaviour
    { 
        [MenuItem("Game/Delete save file", priority = 0)]
        public static void DeleteAllJsonDataFiles()
        {
            int result = EditorUtility.DisplayDialogComplex("Delete save file", "Do you want to delete save file?", "Yes", "No", "");
            
            if (result == 0)
            {
                JsonSaveLoad.DeleteFile(GameData.FileName);
            
                Debug.Log($"<color=red>Save file deleted</color>");

                AssetDatabase.Refresh();
            }
        }
    }
}
#endif
