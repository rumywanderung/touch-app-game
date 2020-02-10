using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Timer;
    int i;
    public Text score; //score text
    public GameObject pointsmanager2 = null;
    public PointsManager pointsmanager = null;
    //[HideInInspector]
    public bool loaded = false;
    public bool canvaLoaded = false;
    public GameObject Objects = null;
    public GameObject Objects2 = null;
    public Dictionary<int, string> ObjectDict = new Dictionary<int, string>();
    Scene currentScene;
    public GameObject canva = null;
    public GameObject buttonEnd;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Start()
    {
        buttonEnd = null;
        Timer = 0;
        i = 0;
        ObjectDict.Add(0, "Cheese3");
        ObjectDict.Add(1, "tomato");
        ObjectDict.Add(5, "champignon");
        ObjectDict.Add(3, "poivron");
        ObjectDict.Add(4, "oignon");
        ObjectDict.Add(2, "PIZZAHUTLOGO");
        ObjectDict.Add(6, "Bazil");

        currentScene = SceneManager.GetActiveScene();
    }

    void LoadEndScene()
    {
        if (loaded == true)
        {
            return;
        }
       
        else if (loaded == false)
        {
            loaded = true;
            DontDestroyOnLoad(canva.gameObject);
            DontDestroyOnLoad(score.gameObject);

            SceneManager.LoadScene("End");
        }
        
    }

    void Update()
    {

        if (SceneManager.GetSceneByName("End").isLoaded)
            {
            if (score != null)
            {
                if (pointsmanager.myPoints < 150)
                {   score.text = "FINAL SCORE: " + pointsmanager.myPoints.ToString() + "/150";
                    buttonEnd = Instantiate(Resources.Load("Button End"), new Vector3(19, 35, 0), Quaternion.identity) as GameObject;
                    Canvas canvaEnd = FindObjectOfType<Canvas>();
                    buttonEnd.transform.SetParent(canvaEnd.transform, false);
                }
                else if (pointsmanager.myPoints >= 150)
                {
                    score.text = "FINAL SCORE: " + pointsmanager.myPoints.ToString();
                    buttonEnd = Instantiate(Resources.Load("Button Next"), new Vector3(19, 35, 0), Quaternion.identity) as GameObject;
                    Canvas canvaEnd = FindObjectOfType<Canvas>();
                    buttonEnd.transform.SetParent(canvaEnd.transform, false);
                }
            }
                pointsmanager = null;
                pointsmanager2 = null;
            }

            if (SceneManager.GetSceneByName("Game").isLoaded)
            {
                if (pointsmanager2 == null && pointsmanager == null)
            {
                pointsmanager2 = Instantiate((Resources.Load("PointsManager") as GameObject), new Vector3(0, 0, 0), Quaternion.identity);
                pointsmanager = pointsmanager2.GetComponent<PointsManager>();
            }
                

            if (canvaLoaded == false && canva == null)
                {
                    canva = Instantiate((Resources.Load("CanvasScore") as GameObject), new Vector3(0, 0, 0), Quaternion.identity);
                    score = canva.GetComponentInChildren<Text>();
                    canvaLoaded = true;
                }

                i++;
                Timer += Time.deltaTime;
               
                #region Create Objects

                if (Timer >= 40F) //500 | 10
                {
                    score.transform.position = new Vector3(((Screen.width / 2) - 47), (Screen.height / 2) + 750, 0F);
                    LoadEndScene();

                    return;
                }

                else if (Timer < 40F && i % 12 == 0)
                {
                    Vector3 randomized = new Vector3(Random.Range(0F, 12F), Random.Range(5F, 15F), 0F);
                    int index = Random.Range(0, 7);
                    Objects = Resources.Load(ObjectDict[index]) as GameObject;
                    Objects2 = Instantiate(Objects, randomized, Quaternion.identity);
                    Destroy(Objects2, 2F);
                }
            }

            #endregion


            if (score != null)
            {
                score.text = "Score: " + pointsmanager.myPoints.ToString();
            }

            

       
        
    }
        
}

