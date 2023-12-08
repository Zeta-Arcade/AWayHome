using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarMove : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject Target;
   
    void Start()
    {
        FindTarget();
    }

    public void FindTarget()
    {
        navMeshAgent.destination = Target.transform.position;
    }
}
