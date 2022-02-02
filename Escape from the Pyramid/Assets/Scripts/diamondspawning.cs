using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondspawning : MonoBehaviour
{
    public GameObject diamond;

    public float spawnRate = 10f;

    public float nextSpawn = 0f;

    Vector3 position;


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            position = new Vector3(Random.Range(-1200f, 1200f) / 10, Random.Range(-600f, 200f) / 10, 0);
            GameObject clone = (GameObject) Instantiate(diamond, position, Quaternion.identity);
            Destroy(clone, 10f);
            nextSpawn = Time.time + spawnRate;
        }
    }
}
