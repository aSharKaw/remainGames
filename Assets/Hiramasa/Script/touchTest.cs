
using UnityEngine;
using System.Collections;


public class touchTest : MonoBehaviour
{

  void Start()
  {

  }

  void Update()
  {
    Debug.Log(touchManager.GetTouch(0));
  }

}
