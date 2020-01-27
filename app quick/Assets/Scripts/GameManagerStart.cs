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
        i--;
        timeLeft -= Time.deltaTime;
        Debug.Log(i);

        if (i%125 == 0)
        {
            timerText.text = "2";
        }

        else if (i <= 50)
        {
            timerText.text = "1";
        }

        if (i <= 0)
        {
            if (i <= -20) { SceneManager.LoadScene("Game"); }
        }
    }
}
