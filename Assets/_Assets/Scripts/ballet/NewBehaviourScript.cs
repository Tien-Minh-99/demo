using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[System.Serializable]
public class EnemyWave
{
    public Transform enemyPrefab;
    public int numberOfEnemy;
    public Vector3 formationOffset;
    public FlyPath flyPath;
    public float speed;
    public float nextWaveDelay;
}