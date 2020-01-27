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
    public bool loaded = false;

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
        i++;
        Timer += Time.deltaTime;

        #region Create Objects
        if (i >= 500 || Timer >= 10) //500 | 10
        {
            Debug.Log("Time's Up!");
            score.transform.position = new Vector3(410F, 800F, 0F);
            //GameObject panel = score.GetComponentInParent<GameObject>();
            //panel.transform.position = new Vector3(410F, 800F, 0F);
            LoadEndScene();
            score.text = "SCORE FINAL: " + pointsmanager.myPoints.ToString();
            
            return;
        }
        
        else if (i < 500 && i % 15 == 0)
        {
            //Debug.Log("else");
            Vector3 randomized = new Vector3(Random.Range(1F, 10F), Random.Range(5F, 20F), 0F);
            GameObject Objects = Resources.Load("Snowmen") as GameObject;
            Instantiate(Objects, randomized, Quaternion.identity);
            //Burger.gameObject.tag = "cube" + j.ToString();
            //j++;
        }

        #endregion

        score.text = "Score: " + pointsmanager.myPoints.ToString();
    }
        
}

