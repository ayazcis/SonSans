using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tryanother : MonoBehaviour
{
    private Animator myanimator;
    private void Start()
    {
        GameObject otherobject = GameObject.Find("Adsýz_Resim-7");
        myanimator = otherobject.GetComponent<Animator>();
    }
    void OnMouseEnter()
    {

        
        Debug.Log("Mouse entered!");
        myanimator.SetBool("isPlay", true);
    }
    private void OnMouseExit()
    {
        Debug.Log("mouse exited");
        myanimator.SetBool("isPlay", false);
    }
}