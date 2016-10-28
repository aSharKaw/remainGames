using UnityEngine;
using System.Collections;

public class destryTime : MonoBehaviour
{
  [SerializeField]
  private float time;

  void Start()
  {
    Destroy(gameObject, time);
  }

  void Update()
  {
  }

}
