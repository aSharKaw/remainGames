
using UnityEngine;
using System.Collections;


public class touchManager : MonoBehaviour
{

  // タッチ情報
  public enum TouchInfo
  {
    //タッチなし
    None = -1,
    // 以下は UnityEngine.TouchPhase の値に対応
    //タッチ開始
    Began = 0,
    //タッチ終了
    Ended = 1,
  }

  //タッチ情報。タッチされていない場合は null
  public static TouchInfo GetTouch(int i)
  {
    if (Input.GetMouseButton(0) || Input.touchCount == 1)
    {
      return TouchInfo.Began;
    }
    if (Input.GetMouseButtonUp(0))
    {
      return TouchInfo.Ended;
    }
    else
    {
      return TouchInfo.None;
    }
  }

  public static int touchCount
  {
    get
    {
      if (Application.isEditor)
      {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
          return 1;
        }
        else
        {
          return 0;
        }
      }
      else
      {
        return Input.touchCount;
      }
    }
  }

}