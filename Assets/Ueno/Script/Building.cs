using UnityEngine;
using System.Collections;


//ダメっ!! 壊れちゃうよおおおぉぉぉぉぉ!!!!(何やってんだ俺...)
public class Building : MonoBehaviour
{
    public GameObject break_Building;

    //ビルの耐久度(とりあえず)
    [SerializeField]
    private int durability;


    void Start()
    {

    }


    void Update()
    {
        //スペースキー押したら耐久度減る(とりあえず)
        if (Input.GetKeyDown("space"))
        {
            durability--;
        }


        //耐久度が0なら差し替え
        if (durability <= 0)
        {
            Instantiate(break_Building,
            new Vector3(transform.position.x,
                        transform.position.y,
                        transform.position.z),
                        Quaternion.identity);

            //元のオブジェクト消去
            Destroy(this.gameObject);
        }
    }
}
