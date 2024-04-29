using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class OreSpawner : MonoBehaviour
{
    [SerializeField] private GameObject orePrefab;
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
            float oreOffset;
            Vector3 spawnPosition = Player.GetPlayerPosition();

            oreOffset = UnityEngine.Random.Range(-1, 1);
            spawnPosition.x = Player.GetPlayerPosition().x -oreOffset;

            oreOffset = UnityEngine.Random.Range(-1, 1);
            spawnPosition.y = Player.GetPlayerPosition().y - oreOffset;

            yield return new WaitForSeconds(spawnTimer);
            Instantiate(orePrefab, spawnPosition, quaternion.identity);
        }
    }
}
