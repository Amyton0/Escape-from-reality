using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool isStart = false;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q) && isStart)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        if (Input.GetKeyUp(KeyCode.E) && isStart)
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
        if (isStart == false)
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isStart = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isStart = false;
    }
}
