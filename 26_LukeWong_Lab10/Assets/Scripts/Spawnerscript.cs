using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;
    float PositionY;
    int RandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        RandomNumber = Random.Range(1, 4);
        if (RandomNumber == 1)
        {
            Instantiate(SpawnObject1, transform.position, transform.rotation);
        }
        else if (RandomNumber == 2)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }
        else if (RandomNumber == 3)
        {
            Instantiate(SpawnObject3, transform.position, transform.rotation);
        }
    }
}
