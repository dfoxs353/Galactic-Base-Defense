using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject menu_main;
    public GameObject menu_Play;
    public GameObject menu_NewGame;
    public GameObject menu_Settings;
    public GameObject menu_LoadGame;
    public GameObject menu_About;


    public void Start()
    {
        menu_main.SetActive(true);
    }

    public void PlayPressed()
    {
        menu_main.SetActive(false);
        menu_Play.SetActive(true);
        Debug.Log("Play pressed");
    }

    public void SettingsPresed()
    {
        menu_main.SetActive(false);
        menu_Settings.SetActive(true);
    }

    public void AboutPressed()
    {
        menu_main.SetActive(false);
        menu_About.SetActive(true);
    }

    public void ContinuePressed()
    {
        Debug.Log("Continue button pressed");
    }
    
    public void BackPlayPressed()
    {
        menu_main.SetActive(true);
        menu_Play.SetActive(false);
    }
    
    public void BackSettingsPressed()
    {
        menu_main.SetActive(true);
        menu_Settings.SetActive(false);
    }
    
    public void BackAboutPressed()
    {
        menu_main.SetActive(true);
        menu_About.SetActive(false);
    }
    
    public void BackNewGamePressed()
    {
        menu_Play.SetActive(true);
        menu_NewGame.SetActive(false);
    }
    
    public void BackLoadGamePressed()
    {
        menu_Play.SetActive(true);
        menu_LoadGame.SetActive(false);
    }
    
    public void LoadGamePressed()
    {
        menu_Play.SetActive(false);
        menu_LoadGame.SetActive(true);
    }
    
    public void NewGamePressed()
    {
        menu_Play.SetActive(false);
        menu_NewGame.SetActive(true);
    }

    public void StoryPressed()
    {
        Debug.Log("Story button pressed");
    }
    
    public void SandboxPressed()
    {
        Debug.Log("SandBox button pressed");
    }
}