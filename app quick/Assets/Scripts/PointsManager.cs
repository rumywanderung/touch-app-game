using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Android;
//using UnityEngine.iOS;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    private float width;
    private float height;
    Renderer cubeRend;
    Ray ray;
    GameManager manager;
    [HideInInspector]
    public float myPoints;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

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

        #region MOBILE
        //MOBILE (to be continued)

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickableObject")
            {
                myPoints += 1;
                Destroy(hit.transform.gameObject);
            }
            else if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickableObject3")
            {
                myPoints += 3;
                Destroy(hit.transform.gameObject);
            }
        }

        #endregion

      /*  if (Input.GetMouseButtonDown(0) == true)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "clickableObject")
                {
                    myPoints += 1;
                    Destroy(hit.transform.gameObject);
                }
                else if (hit.collider.gameObject.tag == "clickableObject3")
                {
                    myPoints += 3;
                    Destroy(hit.transform.gameObject);
                }
            }
        }*/
    }
}


