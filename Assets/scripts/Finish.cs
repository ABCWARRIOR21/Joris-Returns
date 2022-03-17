using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter3D(Collider collision)
    {
        if (collision.gameObject.name == "joris-bohnson" && !levelCompleted)
        {

            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }
    }

    private void CompleteLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}