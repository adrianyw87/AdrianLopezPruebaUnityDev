using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestLap : MonoBehaviour
{
    public Text bestLap_txt;
    void Start()
    {
        //Adrian: Getting bestLap time
        //bestLap_txt = GetComponent<Text>();
        string initialMessage = "Your best lap: ";
        float bestLap = PlayerPrefs.GetFloat("bestLap_historical");
        bestLap_txt.text = bestLap == 0 ? "" : initialMessage + getTimeString(bestLap);
    }

    string getTimeString(float time)
    {
        int timeInt = (int)(time);
        int minutes = timeInt / 60;
        int seconds = timeInt % 60;
        float fraction = (time * 100) % 100;
        if (fraction > 99) fraction = 99;
        return string.Format("{0}:{1:00}:{2:00}", minutes, seconds, fraction);
    }
}
