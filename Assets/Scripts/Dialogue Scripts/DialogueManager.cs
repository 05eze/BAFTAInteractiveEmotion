using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    public CharacterController character;

    void Start()
    {
        sentences = new Queue<string>();
        character = GameObject.Find("Player").GetComponent<CharacterController>();
    }
    
    public void StartDialogue (Dialogue2 dialogue)
    {
      
        character.canMove = false;

        animator.SetBool("isOpen", true);

        Debug.Log("Starting conversation with" + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        //Stops running text if player skips, starts a new one after
        StartCoroutine(TypeSentence(sentence));
    }
    //Making text pop up one character after another
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
            //After each letter, we wait a small amount of time (single frame)
        }
    }


    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        animator.SetBool("isOpen", false);

        character.canMove = true;
    }
}
