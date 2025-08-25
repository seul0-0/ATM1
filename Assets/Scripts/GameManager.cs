using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UserData userData;
    public Text NameText;
    public UIFormat Cash;
    public UIFormat Balance;

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
        userData = new UserData("주슬기", 50000, 100000);
    }

    public void Refresh()
    {
        NameText.text = userData.UserName;
    } 
}