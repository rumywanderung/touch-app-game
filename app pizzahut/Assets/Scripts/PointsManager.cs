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
    public GameObject visualFX;
    public GameObject explosionFX;

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
                visualFX = Resources.Load("PPUn") as GameObject;
                Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                Instantiate(visualFX, pos, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                
                explosionFX = Resources.Load("Explosion") as GameObject;
                Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                Instantiate(explosionFX, pos2, Quaternion.identity);

                visualFX = null;
                explosionFX = null;
            }
            else if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickableObject3")
            {
                myPoints += 5;
                visualFX = Resources.Load("PPCinq") as GameObject;
                Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                Instantiate(visualFX, pos, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                
                explosionFX = Resources.Load("Explosion") as GameObject;
                Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                Instantiate(explosionFX, pos2, Quaternion.identity);

                visualFX = null;
                explosionFX = null;
            }

            else if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickableObject2")
            {
                myPoints -= 1;
                visualFX = Resources.Load("PPX") as GameObject;
                Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                Instantiate(visualFX, pos, Quaternion.identity);
                Destroy(hit.transform.gameObject);

                //explosionFX = Resources.Load("Explosion") as GameObject;
                //Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                //Instantiate(explosionFX, pos2, Quaternion.identity);
                visualFX = null;
                explosionFX = null;
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
                    visualFX = Resources.Load("PPUn") as GameObject;
                    Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                    Instantiate(visualFX, pos, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    
                    explosionFX = Resources.Load("Explosion") as GameObject;
                    Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                    Instantiate(explosionFX, pos2, Quaternion.identity);

                    visualFX = null;
                    explosionFX = null;
                }
                else if (hit.collider.gameObject.tag == "clickableObject3")
                {
                    myPoints += 5;
                    visualFX = Resources.Load("PPCinq") as GameObject;
                    Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                    Instantiate(visualFX, pos, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                   
                    explosionFX = Resources.Load("Explosion") as GameObject;
                    Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                    Instantiate(explosionFX, pos2, Quaternion.identity);

                    visualFX = null;
                    explosionFX = null;
                }

                else if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickableObject2")
                {
                    myPoints -= 1;
                    visualFX = Resources.Load("PPX") as GameObject;
                    Vector3 pos = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2, 0F);
                    Instantiate(visualFX, pos, Quaternion.identity);
                    Destroy(hit.transform.gameObject);

                    //explosionFX = Resources.Load("Explosion") as GameObject;
                    //Vector3 pos2 = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, 0F);
                    //Instantiate(explosionFX, pos2, Quaternion.identity);

                    visualFX = null;
                    explosionFX = null;
                }
            }
        }*/
    }
}


