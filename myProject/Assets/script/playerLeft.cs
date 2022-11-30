using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLeft : MonoBehaviour
{
    public Sprite playerLeftFork;


    //public GameObject pitchFork;

    // Update is called once per frame
    void Update()
    {
        //if the pitchfork y position is higher than 0.4 aka player picks it up
        if (GameObject.Find("pitchfork").transform.position.y > 0.4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = playerLeftFork;
        }
    }
}
