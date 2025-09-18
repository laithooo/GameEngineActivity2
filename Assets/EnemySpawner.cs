using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    public void SpawnEnemy()
    {
        if (enemyPrefab != null && spawnPoint != null)
        {
           Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    Invoke("SpawnEnemy", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}