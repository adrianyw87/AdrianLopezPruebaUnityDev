using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCounterManager : MonoBehaviour
{        
    public int coins;
    public Text CoinsCounterText;
    
    void Start()
    {
        PickUpCoin.coinCollectedEvent += CollectCoin;
        CoinsCounterText = CoinsCounterText.GetComponent<Text>();
        CoinsCounterText.text = 0.ToString();        
    }

    public void CollectCoin()
    {
        coins++;

        if(CoinsCounterText != null)
        CoinsCounterText.text = coins.ToString();
    }
}
