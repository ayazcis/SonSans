using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeyvePuzzle : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    private Camera _camera;
    void Start()
    {
        _camera = Camera.main;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit)
            {
                if(Vector2.Distance(emptySpace.position,hit.transform.position) < 4)
                {
                    Vector2 lastEmptySpacePosition = emptySpace.position;
                    emptySpace.position = hit.transform.position;
                    hit.transform.position = lastEmptySpacePosition;
                }
            }
        }
    }
}
