using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float Timer;
    int i;
    float j;
    public Text score;

    void Start()
    {
        Timer = 0;
        i = 0;
        j = 0;
    }

    void Update()
    {
       
        i++;
        Timer += Time.deltaTime;
        //Debug.Log("Timer = " + Timer);

        #region Create Ghosts
        if (i >= 500 || Timer >= 10)
        {
            return;
        }

        else if (i < 500 && i % 15 == 0)
        {
            //Debug.Log("else");
            Vector3 randomized = new Vector3(Random.Range(2F, -2F), Random.Range(-1F, 7F), 0F);
            GameObject Burger = Resources.Load("Burger") as GameObject;
            Instantiate(Burger, randomized, Quaternion.identity);
            //Burger.gameObject.tag = "cube" + j.ToString();
            //j++;
        }
    }
       

        #endregion
}

