using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameTime : MonoBehaviour
{
    
    float limit_time;//　制限時間
    int minite;     //　制限時間（分）
    float second;	//　制限時間（秒）
    int oldSecond;//　前回Update時の秒数
    bool timerFlag = false;//　タイマーフラグ


    // Use this for initialization
    void Start()
    {
        
        minite = 3;
        second = 2.0f;
        limit_time = minite * 60 + second;
        oldSecond = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            timerFlag = true;
        }
        
        if(timerFlag == true)
        {
            if (Time.timeScale > 0 && limit_time > 0.0f)
            {
                //　一旦トータルの制限時間を計測
                limit_time = minite * 60 + second;
                limit_time -= Time.deltaTime;

                //　再設定
                minite = ((int)(limit_time)) / 60;
                second = limit_time - minite * 60;

                //時間を表示する
                if ((int)(second) != oldSecond)
                {
                    this.GetComponent<Text>().text = minite.ToString("00") + ":" + ((int)second).ToString("00");

                }
                oldSecond = ((int)(second));

                if (limit_time <= 0.0f)
                {
                    Debug.Log("制限時間終了");
                }

            }
        }
       

    
    }

   
}
