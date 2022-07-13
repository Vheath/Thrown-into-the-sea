using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 moveTo = new Vector3(0,0,0);
    
    public bool inversion = false;
    void Start()
    {
        if (inversion)
            moveTo = new Vector3(0,0,-1);
        if(!inversion)
            moveTo = new Vector3(0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    void Moving()
    {
        Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();

         if(rigidbody.position.z <= -26 )
        {
            moveTo = new Vector3(0,0,1); 
        }
        else if(rigidbody.position.z >= 30 )
        {
            moveTo = new Vector3(0,0,-1);
        }

        
        transform.position += moveTo * speed * Time.fixedDeltaTime;
    
    }
}
