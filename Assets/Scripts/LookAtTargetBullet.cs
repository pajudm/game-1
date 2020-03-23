using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTargetBullet : MonoBehaviour
{
    public float speed;
    public float Rspeed;
    public Transform player;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(z, transform.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * Rspeed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }
}