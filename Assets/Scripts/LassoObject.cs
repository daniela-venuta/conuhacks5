using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LassoObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       detectTouch();
    }

    void detectTouch()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(GetComponent<Camera>())
            {
                 Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                 RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
           
        }
        
    }
} 
