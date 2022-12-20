using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    public static GameManager Instance{get {return _instance;}}

    public Menu_Manager MenuManager;
    public HUD_Manager HUDManager;

    private string scene = "main";
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;;
        }
        
        DontDestroyOnLoad(gameObject);

        InitializeMain();
    }

    private void InitializeMain()
    {
        MenuManager = GetComponent<Menu_Manager>();
        HUDManager = GetComponent<HUD_Manager>();
    }
}
