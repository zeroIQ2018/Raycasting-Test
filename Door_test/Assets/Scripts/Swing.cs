using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Animator anim;
    
    void Start()
    {
        bool a = anim.GetBool("State");
        anim.SetBool("State", false);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            bool a = anim.GetBool("State");
            anim.SetBool("State", true);
            StartCoroutine(wait());
        }


        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Enemy")
            {

            }
            
        }
    }
    IEnumerator wait()
    {      
        yield return new WaitForSeconds(1/2);
        bool a = anim.GetBool("State");
        anim.SetBool("State", false);       
    }
}
