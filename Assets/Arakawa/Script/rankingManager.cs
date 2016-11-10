using UnityEngine;
using System.Collections;

public class rankingManager : MonoBehaviour
{

    private string RANKING_KEY = "ranking";
    private int RANKING_NUM = 10;
    private int[] ranking;

    void Start()
    {
        ranking = new int[RANKING_NUM];
    }

    //スコア毎に称号吐き出し
    string rankName(int score)
    {
        //if文で条件取ってだそうか
        return null;
    }

    //ランキング取得
    void getRanking()
    {
        string _ranking = PlayerPrefs.GetString(RANKING_KEY);
        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(","[0]);
            ranking = new int[RANKING_NUM];

            for (int i = 0; i < _score.Length && i < RANKING_NUM; i++)
            {
                ranking[i] = int.Parse(_score[i]);
            }
        }
    }

    //ランキングに格納
    //点数順に格納するので、とりあえず数値突っ込めば対応してくれるよ
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
        for (int i = 0; i < ranking.Length; i++)
        {
            tmpArray[i] = ranking[i].ToString();
        }
        string rankingString = string.Join(",", tmpArray);
        PlayerPrefs.SetString(RANKING_KEY, rankingString);
    }

    //void DrawRanking()
    //{
    //    Vector2 label_ranking = new Vector2(0, 0);
    //    //表示エリア
    //    Rect rect_ranking = new Rect(label_ranking.x / 2, label_ranking.y / 2, label_ranking.x, label_ranking.y);

    //    //空の文字列を作成
    //    string ranking_string = "";
    //    for (int i = 0; i < ranking.Length; i++)
    //    {
    //        //順に並べて表示
    //        ranking_string = ranking_string + (i + 1) + "位" + ranking[i];
    //    }

    //    //表示
    //    //GUI.Label(rect_ranking, ranking_string,)
    //}

    //ランキングデータ削除
    void deleteRanking()
    {
        PlayerPrefs.DeleteKey(RANKING_KEY);
    }




    //void OnGUI()
    //{
    //    GUI.TextField(new Rect(10, 10, 100, 100), "TextField");
    //}




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            getRanking();
            setRanking(Random.Range(0, 100));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PlayerPrefs.GetString(RANKING_KEY));
        }
    }
}
