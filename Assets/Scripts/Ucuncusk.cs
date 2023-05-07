using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ucuncusk : MonoBehaviour
{
    public Camera otherSceneCamera;
    public Material material;
    void Start()
    {
        if (otherSceneCamera.targetTexture != null)
        {
            otherSceneCamera.targetTexture.Release();
        }
        otherSceneCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        material.mainTexture = otherSceneCamera.targetTexture;
    }


}
