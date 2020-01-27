using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float Timer;
    int i;
    public Text score; //score text
    public PointsManager pointsmanager;
    [HideInInspector]
    bool loaded = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        Timer = 0;
        i = 0;
    }

    void LoadEndScene()
    {
        if (loaded == true)
        {
            return;
        }
       
        else if (loaded == false)
        {
            SceneManager.LoadScene("End");
            loaded = true;
        }
        
    }

    void Update()
    {
        Debug.Log("position: " + score.transform.position);

        i++;
        Timer += Time.deltaTime;

        #region Create Objects
        if (i >= 500 || Timer >= 10) //500 | 10
        {
            Debug.Log("Time's Up!");
            score.transform.position = new Vector3(410F, 800F, 0F);
            score.text = "SCORE FINAL: " + pointsmanager.myPoints.ToString();
            LoadEndScene();
            return;
        }
        
        else if (i < 500 && i % 15 == 0)
        {
            //Debug.Log("else");
            Vector3 randomized = new Vector3(Random.Range(2F, -2F), Random.Range(-1F, 7F), 0F);
            GameObject Objects = Resources.Load("Burger") as GameObject;
            Instantiate(Objects, randomized, Quaternion.identity);
            //Burger.gameObject.tag = "cube" + j.ToString();
            //j++;
        }

        #endregion

        score.text = "Score: " + pointsmanager.myPoints.ToString();
    }
        
}

