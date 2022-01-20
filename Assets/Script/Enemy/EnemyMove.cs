using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform big;
    void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void FixedUpdate()
    {
        if (agent.isActiveAndEnabled == true)
        {
            agent.SetDestination(big.position);
        }
    }
}
