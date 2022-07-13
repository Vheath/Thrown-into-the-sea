using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFloater : MonoBehaviour {
    public float speed;
    public Vector3 moveTo = new Vector3();
	// Start is called before the first frame update
	void OnCollisionEnter(Collision collision)
	{
		Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		if (collision.collider.tag == "PlaneX")
		{
			transform.position = new Vector3(-350,rigidbody.position.y, rigidbody.position.z);
		}
		if (collision.collider.tag == "Plane-X")
		{
			transform.position = new Vector3(350, rigidbody.position.y, rigidbody.position.z);
		}
		if (collision.collider.tag == "PlaneZ")
		{
			transform.position = new Vector3(rigidbody.position.x, rigidbody.position.y, -350);
		}
		if (collision.collider.tag == "Plane-Z")
		{
			transform.position = new Vector3(rigidbody.position.x, rigidbody.position.y, 350);
		}
		
		


	}


	void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.position += moveTo * speed * Time.fixedDeltaTime;
    }
}
