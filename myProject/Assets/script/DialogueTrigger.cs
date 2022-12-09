using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;


    private void Start()
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        if (FindObjectOfType<DialogueManager>())
        {
            Debug.Log("dialogue is null");
        }
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
