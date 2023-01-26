using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement : MonoBehaviour
{
    public bool isTriggered = true;
    public Dialogue2 dialogue;

    public void Start()
    {
        if (isTriggered == false)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isTriggered)
        {
            if (other.tag == "Player")
            {
                TriggerDialogue();
            }
        }
    }
}
