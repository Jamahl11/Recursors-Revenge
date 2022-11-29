using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
        public GameObject selectedObject;
        Vector3 offset;
        void Update()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
            //Overlap Point is a 2D physics function in Unity that checks to see
            //if a specific point in the world intersects with a Collider.
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
                if (targetObject)
                {
                    selectedObject = targetObject.transform.gameObject;
                    offset = selectedObject.transform.position - mousePosition;
                }
            }
            // set the position of the now selected object to match the position of the mouse in the world.
            if (selectedObject)
            {
                    selectedObject.transform.position = mousePosition + offset;
            }
            //deselect object
            if (Input.GetMouseButtonUp(0) && selectedObject)
            {
                selectedObject = null;
            }
        }
}
