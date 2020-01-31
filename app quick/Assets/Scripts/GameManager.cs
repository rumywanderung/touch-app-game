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
        score.transform.position = new Vector3(((Screen.width / 2) + 8), (Screen.height - 250), 0F);
    }
    void Start()
    {
        Timer = 0;
        i = 0;
        ObjectDict.Add(0, "Snowm3n");
        ObjectDict.Add(1, "burgeroo");
        ObjectDict.Add(2, "Quickos");
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
            score.transform.position = new Vector3(((Screen.width/2) - 35), (Screen.height/2)+290, 0F);
            LoadEndScene();
            //score.text = "SCORE FINAL: " + pointsmanager.myPoints.ToString();
            score.text = pointsmanager.myPoints.ToString();

            return;
        }
        
        else if (i < 1000 && i % 17 == 0)
        {
            Vector3 randomized = new Vector3(Random.Range(0F, 12F), Random.Range(5F, 15F), 0F);
            int index = Random.Range(0, 3);
            Objects = Resources.Load(ObjectDict[index]) as GameObject;
            Instantiate(Objects, randomized, Quaternion.identity);
        }

        #endregion

        score.text = pointsmanager.myPoints.ToString();
    }
        
}

