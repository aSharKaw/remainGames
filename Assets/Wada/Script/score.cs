using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class score : MonoBehaviour
{
    //スコア
    private static int setScore = 100;
    private int mScore = 0;
    private int testscore = 0;

    public static int getScore
    {
        get { return setScore; }
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //スコア加算
            testscore += setScore;
        }

        if (mScore < testscore)
        {
            mScore += 1;
        }


        GetComponent<Text>().text = "score: " + mScore.ToString();


    }
}
