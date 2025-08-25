using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIFormat : MonoBehaviour
{
    public Text BalanceText; 
    public Text CashText;
    public int Balance;
    public int Cash;

    void Start()
    {
        BalanceText.text = string.Format("{0:N0}", Balance);
        CashText.text = string.Format("{0:N0}", Cash);
    }
    
}
