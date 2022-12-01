using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PirceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;

    void Update()
    {
        PirceTxt.text = "Coin: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = "Level: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}
