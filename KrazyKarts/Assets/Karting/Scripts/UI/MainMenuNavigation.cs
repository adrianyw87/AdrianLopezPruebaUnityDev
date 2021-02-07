using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuNavigation : MonoBehaviour
{
    public GameObject popUp_QuitGame;
    public GameObject Kart;

    void Start () {
        popUp_QuitGame.SetActive(false);
    }

    public void ShowPopUp () {
        popUp_QuitGame.SetActive(true);
        Kart.SetActive(false);
    }

    public void ClosePopUp () {
        popUp_QuitGame.SetActive(false);
        Kart.SetActive(true);
    }

    public void QuitGame () {
         Application.Quit();
    }
}
