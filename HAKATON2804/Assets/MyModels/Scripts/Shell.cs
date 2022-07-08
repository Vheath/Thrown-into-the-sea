using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour

{
    Rigidbody myRigidbody;
    public Transform Arm;
    public  bool flag = false;
    public float throwSpeed = 50f;
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        
    }
    public void PickUp () 
    {
        if(Arm.childCount < 1) 
        {
            flag = true;
            myRigidbody.isKinematic = false;
            transform.SetParent(Arm);
            transform.position = Arm.position;       
            transform.rotation = Arm.rotation;
            myRigidbody.isKinematic = true;
        }
        else {
            Debug.Log("!!!");
        }
    }
    public void Throw ()
    {
        if (flag == true) 
        {
            transform.parent = null;
            myRigidbody.isKinematic = false;
            myRigidbody.AddForce(transform.forward * throwSpeed);
            flag = false;
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            Throw();
        }
    }
}
