using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRight : MonoBehaviour
{
    //public Sprite playerFork;

    public GameObject playerSwitch;
    private Vector3 scaleChange;


    //public GameObject pitchFork;

    private void Start()
    {
        playerSwitch.SetActive(false);
        scaleChange = new Vector3(0.05f, 0.05f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        //if the pitchfork y position is higher than y aka player picks it up
        if (GameObject.Find("pitchfork").transform.position.y > 0.02)
        {
            // this.gameObject.GetComponent<SpriteRenderer>().sprite = playerFork;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            playerSwitch.SetActive(true);
            GameObject.Find("pitchfork").transform.localScale += scaleChange;
            if (GameObject.Find("pitchfork").transform.localScale.x >= 5.98f)
            {
                GameObject.Find("pitchfork").transform.localScale -= new Vector3(5f, 5f, 5f);
                //GameObject.Find("pitchfork").transform.localScale = new Vector3(0f, 0f, 0f);
                //GameObject.Find("pitckfork").SetActive(false);
                GameObject.Find("pitchfork").GetComponent<SpriteRenderer>().enabled = false;
            }

        }
    }
}
