using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltSpawner : MonoBehaviour {

    public GameObject bolt;
    public Transform boltSpawn;
    public int boltSpeed;
    public Vector3 TargetPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawner();
        }
    }

	void Spawner()
    {
        var laserBolt = (GameObject)Instantiate(bolt, boltSpawn.position, boltSpawn.rotation);
        laserBolt.GetComponent<Rigidbody>().velocity = laserBolt.transform.forward * boltSpeed;

    }
}