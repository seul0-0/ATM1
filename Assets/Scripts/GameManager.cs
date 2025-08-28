using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using System.IO;    



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UserData userData;
    /*public Text NameText;*/
    /*public UIFormat Cash;
    public UIFormat Balance;
    */

    void Awake()
    {
         
        if (instance == null) // Singleton Pattern
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        

        if (File.Exists(Application.persistentDataPath + "/UserData.txt"))
        {
            Load();
        }
        else
        {
            userData = new UserData("주슬기", 50000, 100000);
        }
    }

    public void Save()
    {
        var saveData = JsonUtility.ToJson(userData);
        
        File.WriteAllText(Application.persistentDataPath + "/UserData.txt", saveData);
    }

    public void Load()
    {
        var loadData = File.ReadAllText(Application.persistentDataPath + "/UserData.txt");
        userData = JsonUtility.FromJson<UserData>(loadData);
    }
}