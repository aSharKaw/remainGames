
using UnityEngine;
using System.Collections;


public class bldgBreak : MonoBehaviour
{

  Rigidbody rb;

  [SerializeField]
  bool breakBldgFlag;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {

    if (touchManager.touchCount > 0)
    {
      // タッチ開始
      if (touchManager.GetTouch(0) == touchManager.TouchInfo.Began)
      {
        rb.isKinematic = false;
      }

    }
  }

}
