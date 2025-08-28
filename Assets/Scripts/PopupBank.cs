using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    public GameObject Btn;
    public GameObject Deposit;
    public GameObject Withdraw;
    public UIFormat uiFormat;
    public InputField inputDeposit;
    public InputField inputWithdraw;
    public Image PopupError;
    public void OpenDeposit()
    {
        Deposit.SetActive(true);
        Withdraw.SetActive(false);
        Btn.SetActive(false);
    }
    
    public void OpenWithdraw()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(true);
        Btn.SetActive(false);
    }
    
    public void Close()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Btn.SetActive(true); 
    }

    public void DepositBtn(int amount)
    {
        if (GameManager.instance.userData.Cash < amount)
        {
            PopupError.gameObject.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash -= amount;
        GameManager.instance.userData.Balance += amount;
        uiFormat.Refresh();
    }
    
    public void WithdrawBtn(int amount)
    {
        if (GameManager.instance.userData.Balance < amount)
        {
            PopupError.gameObject.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash += amount;
        GameManager.instance.userData.Balance -= amount;
        uiFormat.Refresh();
    }

    public void InputDepositBtn()
    {
        int amount = int.Parse(inputDeposit.text);
        if (GameManager.instance.userData.Cash < amount)
        {
            PopupError.gameObject.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash -= amount;
        GameManager.instance.userData.Balance += amount;
        uiFormat.Refresh();
    }
    
    public void InputWithdrawBtn()
    {
        int amount = int.Parse(inputWithdraw.text);
        if (GameManager.instance.userData.Balance < amount)
        {
            PopupError.gameObject.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash += amount;
        GameManager.instance.userData.Balance -= amount;
        uiFormat.Refresh();
    }
    
    public void ClosePopupError()
    {
        PopupError.gameObject.SetActive(false);
    }
}
