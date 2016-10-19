
using UnityEngine;
using System.Collections;


public class bldgBreak : MonoBehaviour
{

  Rigidbody rb;

  [SerializeField]
  private bool breakBldgFlag;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {

    if (Input.GetKey(KeyCode.Space) && breakBldgFlag)
    {
      rb.isKinematic = false;
    }

  }

}
