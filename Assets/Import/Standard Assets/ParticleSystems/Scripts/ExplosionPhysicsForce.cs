
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
  public class ExplosionPhysicsForce : MonoBehaviour
  {
    
    public float explosionForce = 4;
    private Collider[] cols;

    private static string hoge;

    private IEnumerator Start()
    {
      // wait one frame because some explosions instantiate debris which should then
      // be pushed by physics force
      yield return null;

      float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;

      float r = 10 * multiplier;
      cols = Physics.OverlapSphere(transform.position, r);
      var rigidbodies = new List<Rigidbody>();

      foreach (var col in cols)
      {
        if (col.attachedRigidbody != null && !rigidbodies.Contains(col.attachedRigidbody))
        {
          rigidbodies.Add(col.attachedRigidbody);
        }
      }

      foreach (var rb in rigidbodies)
      {
        rb.AddExplosionForce(explosionForce * multiplier, transform.position, r, 1 * multiplier, ForceMode.Impulse);
      }

    }

    void Update()
    {
      hoge = cols[1].name;
    }

    public static string getHoge
    {
      get { return hoge; }
    }

  }
}