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
    private GameObject Objects = null;
    private Dictionary<int, string> ObjectDict = new Dictionary<int, string>();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        Timer = 0;
        i = 0;
        ObjectDict.Add(0, "Cheeze");
        ObjectDict.Add(1, "tomato");
        ObjectDict.Add(2, "champignon");
        ObjectDict.Add(3, "poivron");
        ObjectDict.Add(4, "oignon");
        ObjectDict.Add(5, "PIZZAHUTLOGO");
        ObjectDict.Add(6, "Bazil");
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
        if (i >= 1000 || Timer >= 10) //500 | 10
        {
            score.transform.position = new Vector3(((Screen.width / 2) - 130), (Screen.height / 2) + 80, 0F);
            LoadEndScene();
            score.text = "SCORE FINAL: " + pointsmanager.myPoints.ToString();
            
            return;
        }
        
        else if (i < 1000 && i % 12 == 0)
        {
            Vector3 randomized = new Vector3(Random.Range(0F, 12F), Random.Range(5F, 15F), 0F);
            int index = Random.Range(0, 7);
            Objects = Resources.Load(ObjectDict[index]) as GameObject;
       
            Instantiate(Objects, randomized, Quaternion.identity);
            //Burger.gameObject.tag = "cube" + j.ToString();
            //j++;
        }

        #endregion

        score.text = "Score: " + pointsmanager.myPoints.ToString();
    }
        
}

