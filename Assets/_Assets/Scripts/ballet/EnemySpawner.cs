using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;

    private int currentWave;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave();
    }

    public void SpawnEnemyWave()
    {
        var waveInfo = enemyWaves[currentWave];
        var starPosition = waveInfo.flyPath[0];
        for(int i = 0; i < waveInfo.numberOfEnemy; i++)
        {
            var enemy = Instantiate(waveInfo.enemyPrefab, starPosition, Quaternion.identity);
            var agent = enemy.GetComponent<FlyPathAgent>();
            agent.flyPath = waveInfo.flyPath;
            agent.flySpeed = waveInfo.speed;
            starPosition += waveInfo.formationOffset;
        }
        currentWave++;
        if (currentWave < enemyWaves.Length)
        {
            Invoke(nameof(SpawnEnemyWave), waveInfo.nextWaveDelay);
        }
    }
 
}
