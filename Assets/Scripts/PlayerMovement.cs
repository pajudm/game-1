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
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(movement * movementSpeed * Time.deltaTime);

 
        if (movement != Vector2.zero)
        {
            //TODO: Make smoother with orientation on turning
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg - 90;
            transform.Find("Player Sprite").rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }
    }
}