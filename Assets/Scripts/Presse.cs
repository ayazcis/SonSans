using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Presse : MonoBehaviour
{
    public Canvas girmek;
    public AudioSource clickportal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            clickportal.Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            girmek.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                //clickportal.Play();
                //SceneManager.LoadScene();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            girmek.gameObject.SetActive(false);
        }
    }

}
