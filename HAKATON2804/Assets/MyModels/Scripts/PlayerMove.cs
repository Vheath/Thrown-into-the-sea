using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start() {
 
    }
 
    // Update is called once per frame
    void Update() {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveX, 0, MoveY) * Time.deltaTime * speed);
        if (Input.GetButtonDown("Jump")) {
            Rigidbody rig = GetComponent<Rigidbody>();
            rig.AddForce(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        }
    }
}
