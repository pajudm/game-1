using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFollow : MonoBehaviour
{
    // Speed Variable
    public float speed;

    // Variables for Box Bullet
    [SerializeField]
    GameObject Bullet;
    [SerializeField]

    GameObject player;
    float fireRate = .2f;
    float nextFire;

    private float strength = 7f;
    private Quaternion targetRotation;
    private float str;
    private Transform target;

    void Start()
    {
        target = player.GetComponent<Transform>();
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        //Rotation
        float z = Mathf.Atan2((target.position.y - transform.position.y), (target.position.x - transform.position.x)) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(z, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * strength);
        // targetRotation = Quaternion.AngleAxis(target.position - transform.position, Vector3.up);
        // str = Mathf.Min(strength * Time.deltaTime, 1);
        // transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, str);

        // _direction = Quaternion.LookRotation(target.position - transform.position, Vector3.forward);
        // transform.rotation = Quaternion.aawLerp(transform.rotation, _direction, Time.time * 2);

        //Move towards
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        tryFiring();
    }

    void tryFiring()
    {

        if (Time.time > nextFire) //Cooldown for next fire
        {
            Instantiate(Bullet.gameObject, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }

    }
}
