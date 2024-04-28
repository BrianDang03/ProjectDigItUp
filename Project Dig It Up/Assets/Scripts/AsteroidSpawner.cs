using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject astroidPrefab;
    [SerializeField] private float spawnTimer = 5f;

    private void Start()
    {
        StartCoroutine(SpawnAstroid());
    }

    // Spawns Astroids. While Loop Very Dangerous
    private IEnumerator SpawnAstroid()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            Instantiate(astroidPrefab, transform.position, quaternion.identity);
        }
    }

}
