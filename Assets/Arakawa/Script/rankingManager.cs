using UnityEngine;
using System.Collections;

public class rankingManager : MonoBehaviour {

    private string RANKING_KEY = "ranking";
    private int RANKING_NUM = 10;
    private int[] ranking;

	// Use this for initialization
	void Start () {
        ranking = new int[RANKING_NUM];
    }
    
    //スコア毎に称号吐き出し
    string rankName(int score)
    {
        return null;
    }

    //ランキング取得
	void getRanking()
    {
        string _ranking = PlayerPrefs.GetString(RANKING_KEY);
        if(_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(","[0]);
            ranking = new int[RANKING_NUM];

            for(int i = 0;i < _score.Length && i < RANKING_NUM; i++)
            {
                ranking[i] = int.Parse(_score[i]);
            }
        }
    }

    void setRanking(int score)
    {
        if (ranking != null)
        {
            int _tmp = 0;
            for (int i = 0; i < ranking.Length; i++)
            {
                if (ranking[i] < score)
                {
                    _tmp = ranking[i];
                    ranking[i] = score;
                    score = _tmp;
                }
            }
        }
        else
        {
            ranking[0] = score;
        }
        //ランキングを文字列に変換
        string[] tmpArray = new string[ranking.Length];
        for(int i = 0; i < ranking.Length; i++)
        {
            tmpArray[i] = ranking[i].ToString();
        }
        string rankingString = string.Join(",", tmpArray);
        PlayerPrefs.SetString(RANKING_KEY, rankingString);
    }	

    void deleteRanking()
    {
        PlayerPrefs.DeleteKey(RANKING_KEY);
    }


    // Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            getRanking();
            setRanking(10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PlayerPrefs.GetString(RANKING_KEY));
        }
	}
}
