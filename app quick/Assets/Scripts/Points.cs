using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Android;
//using UnityEngine.iOS;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private float width;
    private float height;
    Renderer cubeRend;
    Ray ray;
    GameManager manager;
    [HideInInspector]
    public int myPoints;

    void Start()
    {
        width = (float)Screen.width;
        height = (float)Screen.height;
        cubeRend = this.GetComponent<Renderer>();
        manager = FindObjectOfType<GameManager>();
        myPoints = 0;
    }

    void Update()
    {
        Debug.Log(manager.score.text);
        string currentTag = this.gameObject.tag;
        #region MOBILE
        //MOBILE (to be continued)

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //Touch touch = Input.GetTouch(1);
            //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100F);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider != null)
                {
                    myPoints += 1;
                    manager.score.text = myPoints.ToString();
                    Destroy(hit.transform.gameObject);
                }
            }

        }

        #endregion

        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            for (int i = 0; i < 11; i++)
            {
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                        myPoints += 1;
                        manager.score.text = myPoints.ToString();
                        Destroy(hit.transform.gameObject);
                    //}
                }
            }

        }
    }

}

