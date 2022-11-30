using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;

    public Text dialogueText;

    public Text nameText;

    public GameObject dialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        dialogueBox = GameObject.Find("/Canvas/DialogueBox");

    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting Conversation with " + dialogue.name);

        sentences.Clear();

        dialogueBox.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().SetText(dialogue.name);

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

        Debug.Log(sentence);

        dialogueBox.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().SetText(sentence);

    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }


}