
using UnityEngine;
using System.Collections;


public class humanScript : MonoBehaviour
{

  [SerializeField]
  private Transform[] points;

  private int destPoint = 0;
  private NavMeshAgent agent;

  private bool humanHitFlag = false;

  void Start()
  {
    agent = GetComponent<NavMeshAgent>();

    agent.autoBraking = false;

    GotoNextPoint();
  }

  void GotoNextPoint()
  {
    if (points.Length == 0)
    {
      return;
    }

      agent.destination = points[destPoint].position;

      destPoint = (destPoint + 1) % points.Length;
  }

  void Update()
  {
    // エフェクトと人間が当たったか検索
    if (UnityStandardAssets.Effects.ExplosionPhysicsForce.collName == "Human")
    {
      humanHitFlag = true;
      this.gameObject.SetActiveRecursively(false);
    }

    if (agent.remainingDistance < 0.5f && !humanHitFlag)
    {
      GotoNextPoint();
    }

  }

}
