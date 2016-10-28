
using UnityEngine;
using System.Collections;


public class explosinoActive : MonoBehaviour
{

  private GameObject explosion;

  void Awake()
  {
    explosion = GameObject.Find("Explosion");
    explosion.SetActive(false);
  }

  void Update()
  {
    if (touchManager.touchCount > 0)
    {
      // タッチ開始
      if (touchManager.GetTouch(0) == touchManager.TouchInfo.Began)
      {
        // 非推奨から直した
        explosion.SetActive(true);
      }
    }

  }
}
