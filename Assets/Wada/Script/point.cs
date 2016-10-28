using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class point : MonoBehaviour
{

    [SerializeField]
    private static int getScore;


    // Use this for initialization
    void Start()
    {
        getScore = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           GetComponent<Text>().text = "+" + score.getScore;

        }

    }
}
