using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float startdelay = 2;
    public float spawnIntervals = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnrtandomAnimals", startdelay, startdelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void spawnrtandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        int xRange = Random.Range(20, -20);
        Vector3 spwnPos = new Vector3(xRange, 0, 20);
        Instantiate(animalPrefab[animalIndex], spwnPos, animalPrefab[animalIndex].transform.rotation);
    }
}
