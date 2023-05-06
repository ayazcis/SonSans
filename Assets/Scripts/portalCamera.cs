using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCamera : MonoBehaviour
{
    public Transform player;
    public Transform portal;
    public Transform otherscene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = player.position - portal.position;
        transform.position = otherscene.position + playerOffsetFromPortal;
    }
}
