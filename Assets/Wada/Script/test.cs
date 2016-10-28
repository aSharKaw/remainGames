using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class test : MonoBehaviour
{
    //スコア
    public static int setscore;
    public int score = 0;
    int testscore;

    int y = 0;

    // Use this for initialization
    void Start ()
    {
        setscore = 100;
        testscore = score;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown("space"))
        {
            //スコア加算
            testscore += setscore;
        }

        if(score < testscore)
        {
            score += 1;
        }
      

        this.GetComponent<Text>().text = "score: " + score.ToString();
      

    }




}
