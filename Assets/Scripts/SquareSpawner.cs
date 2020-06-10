using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour

{

    [SerializeField]
    GameObject Enemy;
    private float nextSpawn;
    private float spawnRate = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnSquare();
    }

    void spawnSquare()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(Enemy.gameObject, transform.position, transform.rotation);
            nextSpawn = Time.time + spawnRate;
        }
    }
}
