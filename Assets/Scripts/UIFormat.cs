using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIFormat : MonoBehaviour
{
    public Text BalanceText; 
    public Text CashText;
    public Text NameText;
    public int Balance;
    public int Cash;
    public UserData userData;
    

    
    void Start()
    {
        userData = GameManager.instance.userData;
        Refresh();
    }
    
    public void Refresh()
    {
        BalanceText.text = string.Format("{0:N0}", userData.Balance);
        CashText.text = string.Format("{0:N0}", userData.Cash);
        NameText.text = userData.UserName;
        
    }
    
}
