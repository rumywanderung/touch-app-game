using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Pick");
    }

    public void GardenLovers()
    {
        SceneManager.LoadScene("Game");
    }
}
