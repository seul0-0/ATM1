using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UserData userData;

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
        userData = new UserData("주슬기", 500000, 100000);
    }

    public void Refresh()
    {
        
    } 
}