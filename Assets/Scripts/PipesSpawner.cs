using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject PipesPrefab;
    public BirdController Bird;
    public float height;

    void Start()
    {
        StartCoroutine(PipeSpawn(spawnTime));
    }

    public IEnumerator PipeSpawn(float time)
    {
        while (!Bird.isDead)
        {
            Vector3 spawnHeight = new Vector3(1.5f, Random.Range(-height, height), 0);
            Instantiate(PipesPrefab, spawnHeight, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
