using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(AudioSource))]

public class KeyBehaviour : MonoBehaviour
{
    // External References
    public AudioClip Collectible_SFX;
    AudioSource CollectedSFX;
    public bool isSelected;

    // Key Object
    public Transform Collectible;
    public GameObject key;

    // NPC
    public GameObject npc;
    public NavMeshAgent navMeshAgent;
    // Animation
    public bool isWalking = false;
    public Animator characterAnim;


    void Awake()
    {
        // Access NPC
        navMeshAgent = npc.GetComponent<NavMeshAgent>();
        characterAnim = npc.GetComponent<Animator>();
        // Load SFX
        CollectedSFX = GetComponent<AudioSource>();
        // Default Status
        isSelected = false;
    }

   void Update()
    {
        // Check if object is selected
        if (isSelected)
        {
            // Set Destination
            navMeshAgent.SetDestination(Collectible.position);
            StartCoroutine(ExecuteAfterTime(2));
            // Trigger Animation
            if (!isWalking)
            {
                isWalking = true;
                characterAnim.SetBool("isWalking", true);
            }

            // CheckNPC();
        }

        if (!key.activeSelf)
        {
            // Stop Walking
            isWalking = false;
            characterAnim.SetBool("isWalking", false);
            // Play SFX
            //CollectedSFX.PlayOneShot(Collectible_SFX, 0.5f);
        }
    }

    public void OnMouseDown()
    {
        // Collect Object
        isSelected = true;
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Execute after delay
        // Check NPC Progress
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            // "Collect"
            key.gameObject.SetActive(false);

            // Trigger Sound Effect
            if (!key.activeSelf)
            {
                // Play SFX
                // CollectedSFX.PlayOneShot(Collectible_SFX, 0.5f);
            }
        }
    }

    void CheckNPC()
    {
        // Toggle Animation
        if (isWalking)
        {
            characterAnim.SetBool("isWalking", true);
        }
        else
        {
            characterAnim.SetBool("isWalking", false);
        }
    }
}
