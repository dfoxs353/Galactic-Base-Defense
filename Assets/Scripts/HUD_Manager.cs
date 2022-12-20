using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD_Manager : MonoBehaviour
{
    public GameObject pause_menu;
    public GameObject inventory;
    public GameObject toolbar;
    public void MenuPressed()
    {
        pause_menu.SetActive(true);
        Debug.Log("Menu pressed");
    }

    public void CloseMenuPressed()
    {
        pause_menu.SetActive(false);
    }
   
}
