using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator comment;
    public DialogueManager dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        comment.SetBool("isComment", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        comment.SetBool("isComment",false);
    }
}
