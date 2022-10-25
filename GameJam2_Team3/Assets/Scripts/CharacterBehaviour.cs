using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBehaviour : MonoBehaviour
{
    public NavMeshAgent npc;
    public Transform Collectible;
    public KeyBehaviour kB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if object is selected
        if (kB.isSelected) {
            npc.SetDestination(Collectible.position);
            StartCoroutine(ExecuteAfterTime(2));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Execute after delay
        // Check NPC Progress
        if (npc.remainingDistance <= npc.stoppingDistance)
        {
            // "Collect"
            Collectible.gameObject.SetActive(false);
        }
    }
}
