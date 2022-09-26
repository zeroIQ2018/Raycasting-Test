using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class death : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -2)
        {
        #if UNITY_EDITOR

                    UnityEditor.EditorApplication.isPlaying = false;
        #else
                     Application.Quit();
        #endif
        }
    }
}
