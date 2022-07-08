using UnityEngine;

public class Floater : MonoBehaviour {
	Rigidbody myRigidbody;
	public float waterLevel = 0.6f, floatHeight = 0.5f, bounceDamp = 1f, throwSpeed = 50f, speed = 1f;
	public Vector3 buoyancyCentreOffset;
	public Transform Arm;
	private Vector3 moveToX = new Vector3(1, 0, 0);
	private bool doFloater = true;
	[HideInInspector]public bool flag = false;

	
	public void PickUp()
	{
		if (Arm.childCount < 1) 
		{
			flag = true;
			myRigidbody.isKinematic = false;
			transform.SetParent(Arm);
			transform.position = Arm.position;
			transform.rotation = Arm.rotation;
			myRigidbody.isKinematic = true;
			
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Net")
		{
			speed = 0;
			myRigidbody.isKinematic = true;
		}
		if (collision.collider.tag == "Utilizer")
		{
			GameObject.Destroy(gameObject);
		}
	}
	private void Start()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetKeyDown(KeyCode.T))
		{
			if (flag == true)
			{
				flag = false;
				myRigidbody.isKinematic = false;
				myRigidbody.AddForce(transform.forward * throwSpeed);
				transform.parent = null;
				
			}
		}
		if (myRigidbody.position.y >= 1)
		{
			doFloater = false;
		}
		else if (myRigidbody.position.y < 0)
		{
			doFloater = true;
		}

		if (doFloater && flag == false) 
		{
			Vector3 actionPoint = transform.position + transform.TransformDirection(buoyancyCentreOffset);
			float forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);
			transform.position += moveToX * speed * Time.fixedDeltaTime;
			if (forceFactor > 0f)
			{
				Vector3 uplift = -Physics.gravity * (forceFactor - myRigidbody.velocity.y * bounceDamp);
				myRigidbody.AddForceAtPosition(uplift, actionPoint);
			}
		}
	}		
}
