
using UnityEngine;
using System.Collections;


public class humanAITest : MonoBehaviour
{

  [SerializeField]
  private Transform target;

  private NavMeshAgent navMeshAgent;

  void Start()
  {
    navMeshAgent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    navMeshAgent.SetDestination(target.position);
  }

}
