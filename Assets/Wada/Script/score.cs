using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class score : MonoBehaviour
{
    public static int getscore;

  
    // Use this for initialization
    void Start()
    {
        getscore = 0;

                
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            this.GetComponent<Text>().text = "+" + test.setscore;
        }

    }
}
