using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleMovementOpp : MonoBehaviour
{
    public float maxDistanceFromStart;
    //public float speed;
    Vector3 startingPosition;
    //Vector3 speedVector;
    //GameObject eagleObject = GameObject.FindGameObjectWithTag("eagle");

    private void Start()
    {
        startingPosition = this.transform.position;
        //speedVector = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + Vector3.down * Mathf.Sin(Time.realtimeSinceStartup) * maxDistanceFromStart;
    }
}
