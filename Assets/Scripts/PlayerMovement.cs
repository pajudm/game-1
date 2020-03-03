using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class PlayerMovement : MonoBehaviour
{

	public float movementSpeed; 

	//Start is called before the first frame update
	void Start()
	{

	}

	//Update is called once per frame
	void FixedUpdate()
	{
		if(Input.GetKey("w"))
		{
			transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed; 
		}else if(Input.GetKey("s")){
			transform.position -= transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed;
		}

		if(Input.GetKey("a") && !Input.GetKey("d"))
		{
			transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
		}else if(Input.GetKey("d") && !Input.GetKey("a")){
			transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
		}
	}
}