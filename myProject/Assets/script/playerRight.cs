using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRight : MonoBehaviour
{
    public Sprite playerFork;


    //public GameObject pitchFork;

    // Update is called once per frame
    void Update()
    {
        //if the pitchfork y position is higher than y aka player picks it up
        if (GameObject.Find("pitchfork").transform.position.y > -0.151)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = playerFork;
        }
    }
}
