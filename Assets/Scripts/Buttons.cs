using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    Animator anim;
    public GameObject kiz;

    void Start()
    {
        anim = kiz.gameObject.GetComponent<Animator>();
    }

	// Update is called once per frame
	private void Update()
	{
        
    }
    public void Button1()
    {
        anim.SetBool("button1", true);
    }
    public void Button1down()
    {
        anim.SetBool("button1", false);
    }
    public void Button2()
    {
        anim.SetBool("button2", true);
    }
    public void Button2down()
    {
        anim.SetBool("button2", false);
    }
    public void Button3()
    {
        anim.SetBool("button3", true);
    }
    public void Button3down()
    {
        anim.SetBool("button3", false);
    }
    public void Button1click()
	{
        //SceneManager.LoadScene();
	}
    public void Button2click()
	{
        Application.Quit();
	}
}
