using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float asteroidSpeed = 2f;
    [SerializeField] private float destroyTimer = 3f;

    private Vector3 moveToPlayer;

    private float asteroidOffest;

    private void OnEnable()
    {
        moveToPlayer = asteroidSpeed * (Player.GetPlayerPosition() - transform.position).normalized;

        asteroidOffest = Random.Range(-0.5f, 0.5f);
        moveToPlayer.x += asteroidOffest;

        asteroidOffest = Random.Range(-0.5f, 0.5f);
        moveToPlayer.z += asteroidOffest;

        StartCoroutine(DestroyAsteroid());
    }

    private void Update()
    {
        transform.position += moveToPlayer * asteroidSpeed * Time.deltaTime;
    }

    private IEnumerator DestroyAsteroid()
    {
        yield return new WaitForSeconds(destroyTimer);
        Destroy(this.gameObject);
    } 
}
