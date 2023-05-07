using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public string Scenename;
    public void Restart()
    {
        SceneManager.LoadScene(Scenename);
    }
}
