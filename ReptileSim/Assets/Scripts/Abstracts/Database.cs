using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Database
{
   private string path = Application.dataPath + "/Resources/Saves/";
    
   public void SaveData<T>(string saveName, T saveData)
   {
       
    
    string jsonToSave = JsonUtility.ToJson(saveData);
    Debug.Log(jsonToSave);
    Debug.Log(saveName);
    File.WriteAllText(path+saveName+".json",jsonToSave);
   }
   
   public void LoadData<T>(string saveName, System.Action<T> callback)
   {
   
        Debug.Log("Load Data");
        if(File.Exists(path + saveName + ".json"))
        {
            string loadedJson = File.ReadAllText(path + saveName + ".json");
            callback(JsonUtility.FromJson<T>(loadedJson));
        }
        
        else
        {
            Debug.Log("File Doesn't Exist");
        }
   }
}
