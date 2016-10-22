
using UnityEngine;
using System.Collections;


public class explosinoActive : MonoBehaviour
{

  void Update()
  {
    if (touchManager.touchCount > 0)
    {
      // タッチ開始
      if (touchManager.GetTouch(0) == touchManager.TouchInfo.Began)
      {
        // 現在非推奨関数、そのうち直す。
        this.gameObject.SetActiveRecursively(true);
      }
    }

  }
}
