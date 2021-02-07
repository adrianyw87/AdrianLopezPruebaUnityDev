using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTotalCoins : MonoBehaviour
{
    public Text totalCoins_text;
    void Start()
    {
        //Adrian: Getting total coins
        int totalCoins = PlayerPrefs.GetInt("historicalCoins");        
        totalCoins_text.text = totalCoins.ToString();
    }
}
