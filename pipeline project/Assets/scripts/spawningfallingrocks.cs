using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningfallingrocks : MonoBehaviour
{
    public Object rock;
    public Transform[] SpawningLocation;
    public float lastSpawnTime = -300f;
    public float nextSpawnTime = 3f;
    int number;
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime > nextSpawnTime)
        {
            number = Random.Range(0, 5);
            Debug.Log(number);
            nextSpawnTime = Random.Range(0, 3);
            lastSpawnTime = Time.time;
            if (number == 0)
            {
                Instantiate(rock, SpawningLocation[number].position, Quaternion.identity);
                Debug.Log("Spawn 1");
            }

            if (number == 1)
            {
                Instantiate(rock, SpawningLocation[number].position, Quaternion.identity);
                Debug.Log("Spawn 2");
            }

            if (number == 2)
            {
                Instantiate(rock, SpawningLocation[number].position, Quaternion.identity);
                Debug.Log("Spawn 3");
            }

            if (number == 3)
            {
                Instantiate(rock, SpawningLocation[number].position, Quaternion.identity);
                Debug.Log("Spawn 4");
            }

            if (number == 4)
            {
                Instantiate(rock, SpawningLocation[number].position, Quaternion.identity);
                Debug.Log("Spawn 5");
            }
        }
    }
}
