using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryanothercredits : MonoBehaviour
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
        myanimator.SetBool("isCredits", true);
    }
    private void OnMouseExit()
    {
        Debug.Log("mouse exited");
        myanimator.SetBool("isCredits", false);
    }
}
