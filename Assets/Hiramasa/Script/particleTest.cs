
using UnityEngine;
using System.Collections;


public class particleTest : MonoBehaviour
{

  void Start()
  {

  }

  void Update()
  {

  }

  void OnParticleCollision(GameObject obj)
  {
    Debug.Log("name " + obj.name);
  }

}
