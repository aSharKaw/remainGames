using UnityEngine;
using System.Collections;

//ダメっ!! 壊れちゃうよおおおぉぉぉぉぉ!!!!(何やってんだ俺...)
public class bldg : MonoBehaviour
{
  [SerializeField]
  private GameObject breakBldg;

  //ビルの耐久度(とりあえず)
  [SerializeField]
  private int duraBility;

  void Start()
  {
  }

  void Update()
  {
    //スペースキー押したら耐久度減る(とりあえず)
    if (Input.GetKeyDown("space"))
    {
      duraBility--;
    }

    //耐久度が0なら差し替え
    if (duraBility <= 0)
    {
      Instantiate(breakBldg,
      new Vector3(transform.position.x,
                  transform.position.y,
                  transform.position.z),
                  Quaternion.identity);

      //元のオブジェクト消去
      Destroy(gameObject);
    }
  }

}
