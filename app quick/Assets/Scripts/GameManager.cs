using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int NumGhosts;
    float Timer;
    public int i;

    void Start()
    {
        NumGhosts = 10;
        Timer = 0;
        i = 0;
    }

    void Update()
    {
        i++;
        Timer += Time.deltaTime;
        //Debug.Log("Timer = " + Timer);

        #region Create Ghosts
        if (i >= 3000 || Timer >= 10)
        {
            return;
        }

        else if (i < 3000 && i % 11 == 0)
        {
            Debug.Log("else");
            Vector3 randomized = new Vector3(Random.Range(10F, -10F), Random.Range(0F, 12F), 0F);
            GameObject Ghost = Resources.Load("Burger") as GameObject;
            Instantiate(Ghost, randomized, Quaternion.identity);
        }
    }
       

        #endregion
}

