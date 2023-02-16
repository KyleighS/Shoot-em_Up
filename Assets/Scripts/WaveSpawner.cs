using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{

    public enum SpawnState { Spawning, Waiting, Counting };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }
    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.Counting;


    private void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    private void Update()
    {
        waveCountdown -= Time.deltaTime;

        if (state != SpawnState.Waiting)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                //return;
            }
        }

        if (waveCountdown <= 0 && !EnemyIsAliveNoCooldown())
        {
            //if (state == SpawnState.Spawning || state == SpawnState.Counting)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
            waveCountdown = timeBetweenWaves;
        }

    }
    void WaveCompleted()
    {
        state = SpawnState.Counting;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
        }

        nextWave++;

    }
    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("Enemy") == null)
            {
                return false;
            }
        }

        return true;
    }

    bool EnemyIsAliveNoCooldown()
    {
        return GameObject.FindGameObjectsWithTag("Enemy") == null;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);

        state = SpawnState.Spawning;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);

            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.Waiting;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {

        Debug.Log("Spawing Enemy" + _enemy.name);
        Instantiate(_enemy, new Vector3(transform.position.x, 0.0f, transform.position.z), transform.rotation);
    }
}
