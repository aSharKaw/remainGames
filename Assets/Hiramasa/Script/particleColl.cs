
using UnityEngine;
using System.Collections;


public class particleColl : MonoBehaviour
{
  
  void OnParticleCollision(GameObject obj)
  {
    //if (obj.gameObject.tag == "Human")
    {
      Debug.Log(obj.gameObject.name);
    }
  }

}
