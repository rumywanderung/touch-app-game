using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int NumGhosts;
    int i;
    float Timer;

    void Start()
    {
        NumGhosts = 10;
        i = 0;
        Timer = 0;
    }

    void Update()
    {
        Timer += Time.deltaTime;
        Debug.Log(i);
        #region Create Ghosts
        if (i == 16)
        {
            return;
        }

        else
        {
            Debug.Log("else");

            for (i = 0; i <= 2; i++)
            {
                //if (i % 3 == 0) // multiple of 3
                if (Timer % 2 == 0)
                {
                    Vector3 randomized = new Vector3(Random.Range(0F, 10F), Random.Range(0F, 15F), 0F);
                    GameObject Ghost = Resources.Load("Ghost") as GameObject;
                    Instantiate(Ghost, randomized, Quaternion.identity);
                    Timer = 0;
                }
            }
        }
       

        #endregion
    }
}
