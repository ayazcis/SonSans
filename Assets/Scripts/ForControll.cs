using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForControll : MonoBehaviour
{
    public Transform obje1;
    public Transform obje2;
    public Transform obje3;
    public Transform obje4;
    public Transform obje5;
    public Transform obje6;
    public Transform obje7;
    public Transform obje8;
    public GameObject sceneObje;
    void Start()
    {
        
    }

  
    void Update()
    {
        if((obje2.transform.position.x == 0 && obje2.transform.position.y == 3) || (obje2.transform.position.x == 0 && obje2.transform.position.y == -3))
        {
            if((obje7.transform.position.x == 0 && obje7.transform.position.y == -3) || (obje7.transform.position.x == 0 && obje7.transform.position.y == 3))
            {
                if ((obje1.transform.position.x == -3) && (obje4.transform.position.x == -3) && (obje6.transform.position.x == -3))
                {
                    if ((obje3.transform.position.x == 3) && (obje5.transform.position.x == 3) && (obje8.transform.position.x == 3))
                    {
                        sceneObje.SetActive(true);
                    }
                }
            }
            
        }
        
    }
}
