using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent playerAgent;
    public bool hasInteracted;
    private Vector3 currentDestination;


    public virtual void MoveToInteraction(NavMeshAgent playerAgent) {
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 5;
        hasInteracted = false;
        playerAgent.SetDestination(this.transform.position);
    }

    private void Update()
    {
        if (playerAgent != null && !playerAgent.pathPending && !hasInteracted)
        {
            if (playerAgent.remainingDistance < playerAgent.stoppingDistance) {
                Interact();
                hasInteracted = true;

            }
        }
    }

    public virtual void Interact() {
    }
}
