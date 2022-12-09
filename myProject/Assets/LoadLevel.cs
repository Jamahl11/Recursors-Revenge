using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int iLevelToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        //if (collisionGameObject.name == "Player")
        //{
        //    LoadScene();
        //}

        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(iLevelToLoad, LoadSceneMode.Single);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(iLevelToLoad, LoadSceneMode.Single);
    }
}

