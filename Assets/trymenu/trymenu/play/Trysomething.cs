using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trysomething : MonoBehaviour


{
    public GameObject buttonumuz;

    private Animator animator;
    private Animator btanimator;
    // Start is called before the first frame update
    void Start()
    {
        Animator btanimator = buttonumuz.GetComponent<Animator>();
        animator = GetComponent<Animator>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        AnimatorStateInfo stateInfo = btanimator.GetCurrentAnimatorStateInfo(0);
        bool isHighlighted = stateInfo.IsName("Highlighted");

        if (isHighlighted)
            
        {
            Debug.Log("ues");
            animator.SetBool("isPlay", true);
        }
        else
        {
            animator.SetBool("isPlay", false);
            Debug.Log("uaaaaes");
        }
    }
}
