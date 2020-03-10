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

    float fireRate = .2f;
    float nextFire;


    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        
        if(Time.time > nextFire)
        {
            Instantiate(Bullet.gameObject, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }
}
