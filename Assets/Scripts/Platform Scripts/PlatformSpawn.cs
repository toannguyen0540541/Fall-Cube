using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{

    public GameObject platformPrefabs, spikePlatformPrefabs;

    public float timeSpawn = 1f;

    private float currentTimePawn;
    private int countPlatform = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentTimePawn = timeSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        _spawnPlatform();
    }

    void _spawnPlatform()
    {
        currentTimePawn += Time.deltaTime;
        GameObject newPlatform = null;
        Vector2 temp = transform.position;
        temp.x = Random.Range(-2f, 2f);


        if (currentTimePawn >= timeSpawn)
        {
            countPlatform += 1;

            if (countPlatform <= 3)
            {
                newPlatform = Instantiate(platformPrefabs, temp, Quaternion.identity);
            }else if (countPlatform == 4)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefabs, temp, Quaternion.identity);
                }else
                {
                    newPlatform = Instantiate(spikePlatformPrefabs, temp, Quaternion.identity);
                }
                countPlatform = 0;
            }
            currentTimePawn = 0f;
            if (newPlatform)
            {
                newPlatform.transform.parent = transform;
            }
        }

    }

}//class














