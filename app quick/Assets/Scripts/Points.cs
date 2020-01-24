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

    void Start()
    {
        width = (float)Screen.width;
        height = (float)Screen.height;
        cubeRend = this.GetComponent<Renderer>();
    }

    private void OnGUI()
    {
        /*
        GUI.skin.label.fontSize = (int)(Screen.width / 2f);
        GUI.Label(new Rect(20, 20, width, height * 0.25f));
        */
    }
    
    void Update()
    {
        #region MOBILE
        //MOBILE (to be continued)

        /* if (Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(1);
             Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

             Ray ray = Camera.main.ScreenPointToRay(touch.position);
             RaycastHit hit;
             //Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100F);

             if(Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "cube1")
             {
                 if (hit.collider != null)
                 {
                     if (touch.phase == TouchPhase.Began && cubeRend.gameObject.tag == "cube1")
                     {
                         this.cubeRend.material.SetColor("_Color", Color.blue);
                     }
                 }
             }

         }*/
        #endregion
        
        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            for (int i = 0; i < 11; i++)
            {
                if (Physics.Raycast(ray, out hit))
                   {
                     //if (cubeRend.gameObject.tag == "cube1")
                     //{
                         Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100F);
                         //this.cubeRend.material.SetColor("_Color", Color.red);
                         Destroy(this.gameObject);
                         Debug.Log("mouse click");
                     }
                }
            }
            
        }
    }

