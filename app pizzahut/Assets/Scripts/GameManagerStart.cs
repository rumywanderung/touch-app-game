using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerStart : MonoBehaviour
{

    float timeLeft;
    int i;
    public Text timerText;
   
    void Start()
    {
        timeLeft = 250;
        i = 250;
    }

    
    void Update()
    {

        ///////////////TIMER

       /* i--;
        timeLeft -= Time.deltaTime;
        Debug.Log(i);

        if (i == 150)
        {
            timerText.text = "2";
        }

        else if (i <= 50)
        {
            timerText.text = "1";
        }

        if (i <= 0)
        {
            if (i <= -80) { SceneManager.LoadScene("Game"); }
        }*/



    }
}
