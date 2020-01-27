using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObjectDontDestroy : MonoBehaviour
{

    private Scene currentScene;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        //currentScene = SceneManager.GetActiveScene();
    }
    /*
    void Update()
    {
        if (this.gameObject.tag == "Canvas")
        {
            if (currentScene.name == "End")
            {
                Destroy(this.GetComponent<Transform>().GetChild(0).gameObject);
            }
        }
    }
    */
}
