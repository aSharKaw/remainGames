using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonSelect : MonoBehaviour
{

  void Start()
  {

  }

  void Update()
  {
    GetComponent<Button>().Select();
  }

}
