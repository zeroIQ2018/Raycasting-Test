using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    
    
    public Image dot;



    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            
               
            if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2, Camera.main.nearClipPlane)), out hit, 10))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if(hit.collider.CompareTag("Door"))
                {
                    bool h = hit.collider.GetComponent<Animator>().GetBool("Open");
                    hit.collider.transform.GetComponent<Animator>().SetBool("Open", !h);
                    Debug.Log(h);

                    if(h == false)
                    {
                        dot.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    }

                    else
                    {
                        dot.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
                    }
                        

                    
                }

            }

        }
    }
}
