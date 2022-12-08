using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickEagle2 : MonoBehaviour
{
    SpriteRenderer eagleSpriteRenderer;
    int frame = 0;
    int start = 0;

    void Start()
    {
        eagleSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseEnter()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //now your gameObject was clicked!
            Debug.Log("Eagle 2 is clicked!");
            eagleSpriteRenderer.color = Color.red;
            start = 1;
        }
    }

    private void updateEagle()
    {
        frame++;
        if (frame >= 400)
        {
            Debug.Log("Frame move");
            eagleSpriteRenderer.enabled = false;
            start = 0;
        }
    }

    void Update()
    {
        if (start == 1)
        {
            updateEagle();
        }
    }
}
