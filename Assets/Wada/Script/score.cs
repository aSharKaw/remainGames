using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class score : MonoBehaviour
{
    
    private static int setScore = 0; //加算されるスコア
    private int mScore = 0; //メインのスコア
    private int testscore = 0; //

    private static bool isPush = false;

    public static int getScore
    {
        get { return setScore; }
    }

    public static bool push
    {
        get { return isPush; }
    }

    void Start()
    {
    }

    void Update()
    {
        //  時間START
        if (gameTime.tFlag)
        {

            //spaceをしたら１００増える
            if (Input.GetKeyDown(KeyCode.F1))
            {
                setScore = 100;
                testscore += setScore;

                StartCoroutine("pushFlag");
            }
            //enterを押したら10増える
            if (Input.GetKeyDown(KeyCode.F2))
            {
                setScore = 10;
                testscore += setScore;

                StartCoroutine("pushFlag");
            }

            //スコア加算
            if (mScore < testscore)
            {
                mScore += (setScore / 10);
            }
            //スコア表示
            GetComponent<Text>().text = "score: " + mScore.ToString();
          
        }
    }

    //スコア加算されたら、一秒後に消す。
    IEnumerator pushFlag()
    {
        isPush = true;
        yield return new WaitForSeconds(1);
        isPush = false;
    }
}
