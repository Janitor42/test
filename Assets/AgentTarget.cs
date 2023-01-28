using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTarget : MonoBehaviour
{
    public Transform Goal;
    private NavMeshAgent _Agent;
    void Start()
    {
         _Agent = GetComponent<NavMeshAgent>();
        

    }

    public void Update()
    {
        _Agent.destination = Goal.position;
    }

}
