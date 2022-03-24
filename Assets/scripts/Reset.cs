using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        print("Entering the " + other.gameObject.name);
    }


    private void OnTriggerstay(Collider other)
    {
        print("In the " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exiting the " + other.gameObject.name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}