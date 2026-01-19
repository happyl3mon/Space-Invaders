using System.Runtime.Serialization.Json;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject EnemySquare;
    [SerializeField] private float spawnRangeX;
    private float spawnTimerSQ;
    private float maxTimeSQ = 1f;
    private int enemyCountSQ = 12;
    private float rowWidth = 9f;
    private Vector3 spawnCenter = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimerSQ > maxTimeSQ)
        {
            //SpawnEnemySquare();
            spawnTimerSQ = 0f;
        }
        spawnTimerSQ += Time.deltaTime;
    }

    void SpawnEnemySquare()
    {
        if (enemyCountSQ <= 1) return;

        float spacing = rowWidth / (enemyCountSQ - 1);
        float startX = spawnCenter.x - rowWidth / 2f;

        for (int i = 0; i < enemyCountSQ; i++)
        {
            Vector3 spawnLoc = new Vector3(startX + spacing * i, 4f, spawnCenter.z);
            GameObject enemySquare = Instantiate(EnemySquare, spawnLoc, Quaternion.identity);
        }

    }
}
