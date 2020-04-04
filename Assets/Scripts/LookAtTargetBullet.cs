using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTargetBullet : MonoBehaviour
{
    public float speed;
    public float Rspeed;
    private GameObject target;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float z = Mathf.Atan2((target.transform.position.y - transform.position.y), (target.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(z, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * Rspeed);
    }

}

