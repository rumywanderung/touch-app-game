using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{

    GameManager manager;
    PointsManager ptsmanager;
    
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        ptsmanager = FindObjectOfType<PointsManager>();
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    { 
        SceneManager.LoadScene("Pick");
    }

    public void Restart()
    {
        if (manager.canva != null && manager.score != null)
        {
            manager.canva = null;
            manager.score.text = null;
            manager.score = null;
            manager.canvaLoaded = false;
        }

        ptsmanager = null;
        Destroy(manager.gameObject);
        Destroy(manager.buttonEnd.gameObject);

        SceneManager.LoadScene("Start");
    }

    public void GardenLovers()
    {
        SceneManager.LoadScene("INGR_3");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tuto");
    }

    public void MakeIt_GL()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
