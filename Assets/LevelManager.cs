using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Transform mainMenu, settings, credits, howToPlay;
    //Escolher a cena a carregar
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
        //SceneManager.LoadScene(name);
        
    }

    public void SettingsMenu(bool clicked)
    {
        if(clicked==true)
        {
            settings.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            settings.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void CreditsMenu(bool clicked)
    {
        if (clicked == true)
        {
            credits.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            credits.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void HowToPlayMenu(bool clicked)
    {
        if (clicked == true)
        {
            howToPlay.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            howToPlay.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
