using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class gameTime : MonoBehaviour
{
    private float limitTime;//　制限時間
    private int minite = 1;     //　制限時間（分）
    private float second = 2.0f;	//　制限時間（秒）
    private int oldSecond = 0;//　前回Update時の秒数
    private static bool timerFlag = false;//　タイマーフラグ

    private float countDown = 4; //カウントダウン
    private bool countFlag = false;
    private float alpha = 1.0f;

    [SerializeField]
    private Text limitTimeText; //制限時間のText
    [SerializeField]
    private Text countDownText; //ゲーム開始のCountのText

    private ParticleSystem mParticle;//パーティクル

    public static bool tFlag
    {
        get { return timerFlag; }
    }

    void Awake()
    {
        limitTime = minite * 60 + second;

        countDownText = countDownText.GetComponent<Text>();
        limitTimeText = limitTimeText.GetComponent<Text>();


    }

    void Update()
    {
        //クリックしたら、カウントダウン開始
        if (Input.GetMouseButtonDown(0))
        {
            countFlag = true;
        }

        //カウントダウン
        if (countFlag)
        {
            countDown -= Time.deltaTime;

            //カウントダウンを表示
            countDownText.color = new Color(0, 0, 0, alpha);
            countDownText.text = ((int)countDown).ToString();

            alpha -= Time.deltaTime;

            if (alpha <= 0.0f && countDown > 0)
            {
                alpha += 1.0f;
            }

            //カウントダウンが0になったら
            if (countDown < 0)
            {
                countDown = 0;
                countDownText.color = new Color(0, 0, 0, alpha);

                limitTimeText.color = new Color(0, 0, 0, 1);
                alpha -= 0.05f;
                timerFlag = true;
            }
        }

        //制限時間が開始
        if (timerFlag)
        {
            if (Time.timeScale > 0 && limitTime > 0.0f)
            {
                //　一旦トータルの制限時間を計測
                limitTime = minite * 60 + second;
                limitTime -= Time.deltaTime ;

                //　再設定
                minite = ((int)(limitTime)) / 60;
                second = limitTime - minite * 60;

                //時間を表示する
                if ((int)(second) != oldSecond)
                {
                    limitTimeText.text = minite.ToString("00") + ":" + ((int)second).ToString("00");
                }
                oldSecond = ((int)(second));

               

                //時間が0になったら
                if (limitTime <= 0.0f)
                {
                    Debug.Log("終了");
                    
                }
            }
        }
    }
    

}
