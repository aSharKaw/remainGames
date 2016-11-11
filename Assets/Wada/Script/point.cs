using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class point : MonoBehaviour
{
    [SerializeField]
    private Text pointText;

    private float alpha = 1.0f;

    void Start()
    {
        pointText = pointText.GetComponent<Text>();
    }

    void Update()
    {
          //ポイントが入ったら
        if (score.push)
        {
            alpha -= 0.1f;
           
            pointText.color = new Color(1, 0.5f, 0, alpha);
            pointText.text = "+" + score.getScore;

            if(alpha <= 0.0f)
            {
                alpha = 0.0f;
            }
        }
        
        if(alpha == 0.0f)
        {
            alpha = 1.0f;
        }

        //ポイントが入っていないとき
        if(!score.push)
        {
            pointText.color = new Color(0, 1, 0, alpha * 0);
        }
    }
}