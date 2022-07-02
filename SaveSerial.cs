using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System;


public class SaveSerial: MonoBehaviour
{
    int intToSave;
    float floatToSave;
    bool boolToSave;

    bool saved =false;
   

    public GameObject player;
    string ChunkNameToSave;
    public ChunkPlacer chunkPlacerScript;

    public List<GameObject> Levels = new List<GameObject>();

    int levelToSave;

    int errorLevelNumber =0;
    //Transform PlayerPosToSave;
    //public Health HealthScript;
    void Start()
    {
        if (saved)
            LoadGame();
        else
            ResetData();
    }
   /* void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 125, 50), "Raise Integer"))
            intToSave++;
        if (GUI.Button(new Rect(0, 100, 125, 50), "Raise Float"))
            floatToSave += 0.1f;
        if (GUI.Button(new Rect(0, 200, 125, 50), "Change Bool"))
            boolToSave = boolToSave ? boolToSave = false : boolToSave = true;

        GUI.Label(new Rect(375, 0, 125, 50), "Integer value is " 
            + intToSave);
        GUI.Label(new Rect(375, 100, 125, 50), "Float value is " 
            + floatToSave.ToString("F1"));
        GUI.Label(new Rect(375, 200, 125, 50), "Bool value is " 
            + boolToSave);

        if (GUI.Button(new Rect(750, 0, 125, 50), "Save Your Game"))
            SaveGame();
        if (GUI.Button(new Rect(750, 100, 125, 50), "Load Your Game"))
            LoadGame();
        if (GUI.Button(new Rect(750, 200, 125, 50), "Reset Save Data"))
            ResetData();
    }*/

    [Serializable]
    class SaveData
    {
    public int savedInt;
    public float savedFloat;
    public bool savedBool;
    
    public float savedPlayerPosX;
    public float savedPlayerPosY;
    public float savedPlayerPosZ;
    public int savedHealth;
    

    public string savedChunkName;
    public int savedLevelNumber;


    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter(); 
        FileStream file = File.Create(Application.persistentDataPath 
            + "/MySaveData.dat"); 
        SaveData data = new SaveData();
        data.savedInt = intToSave;
        data.savedFloat = floatToSave;
        data.savedBool = boolToSave;
        data.savedPlayerPosX = player.transform.position.x;
        data.savedPlayerPosY = player.transform.position.y;
        data.savedPlayerPosZ = player.transform.position.z;
        data.savedHealth = player.GetComponent<Health>().health;

        data.savedLevelNumber = int.Parse(chunkPlacerScript.FirstChunk.gameObject.transform.parent.name[3].ToString())+1;
        data.savedChunkName = chunkPlacerScript.FirstChunk.transform.name;

        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game data saved!");
    }

    public void LoadGame()
    {
    if (File.Exists(Application.persistentDataPath 
        + "/MySaveData.dat"))
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = 
        File.Open(Application.persistentDataPath 
        + "/MySaveData.dat", FileMode.Open);
        SaveData data = (SaveData)bf.Deserialize(file);
        file.Close();
        intToSave = data.savedInt;
        floatToSave = data.savedFloat;
        boolToSave = data.savedBool;
        Debug.Log(data.savedPlayerPosX);

        
        chunkPlacerScript.FirstChunk = Levels[data.savedLevelNumber].transform.Find(data.savedChunkName).GetComponent<Chunk>();

        Vector3 PlayerPosition = new Vector3 (data.savedPlayerPosX, data.savedPlayerPosY, data.savedPlayerPosZ);
        player.transform.position = (PlayerPosition); 
        player.GetComponent<Health>().health = data.savedHealth;
        
        Debug.Log("Game data loaded!");
        Debug.Log(player.transform.position.x);

    }
    else
        ResetData();
    }

    public void ResetData()
    {
        BinaryFormatter bf = new BinaryFormatter(); 
        FileStream file = File.Create(Application.persistentDataPath 
            + "/MySaveData.dat"); 
        SaveData data = new SaveData();
        data.savedInt = 0;
        data.savedFloat = 0;
        data.savedBool = true;
        data.savedPlayerPosX = 0;
        data.savedPlayerPosY = 10;
        data.savedPlayerPosZ = 0;
        data.savedHealth = 5;
        data.savedLevelNumber =0;
        data.savedChunkName = "Terrain_(-500.0, 0.0, -500.0)";

        bf.Serialize(file, data);
        file.Close();
        saved = true;
        Debug.Log("Game data reset!");
    }
        /*
    if (File.Exists(Application.persistentDataPath 
        + "/MySaveData.dat"))
    {
        File.Delete(Application.persistentDataPath 
        + "/MySaveData.dat");
        intToSave = 0;
        floatToSave = 0.0f;
        boolToSave = false;
        Debug.Log("Data reset complete!");
    }
    else
        Debug.LogError("No save data to delete.");
    }*/
}



