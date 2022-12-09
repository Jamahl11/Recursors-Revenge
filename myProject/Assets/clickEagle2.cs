using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickEagle2 : MonoBehaviour
{
    SpriteRenderer eagle2SpriteRenderer;
    int frame = 0;
    int start = 0;

    void Start()
    {
        eagle2SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    //void OnMouseEnter()
    //{
      //  if (Input.GetMouseButtonDown(0))
        //{
          //  //now your gameObject was clicked!
           // Debug.Log("Eagle is clicked!");
            //eagleSpriteRenderer.color = Color.red;
            //start = 1;
       // }
    //}

    private void updateEagle()
    {
        frame++;
        if (frame >= 100)
        {
            Debug.Log("Frame move");
            eagle2SpriteRenderer.enabled = false;
            start = 0;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //now your gameObject was clicked!
            Debug.Log("Eagle is clicked!");
            eagle2SpriteRenderer.color = Color.red;
            start = 1;
        }

        if (start == 1)
        {
            updateEagle();
        }
    }
}
