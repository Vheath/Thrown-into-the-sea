using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    int layerMask = 1 << 8;
    RaycastHit hit;
    public float distance = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.tag == "Shell")
                {
                    hit.collider.GetComponent<Floater>().PickUp();
                }
            }
        }




    }
}
