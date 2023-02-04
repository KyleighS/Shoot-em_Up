using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    [System.Serializable]
    public class waveContent
    {
        [SerializeField] GameObject[] EnemySpawner;

        public GameObject[] GetEnemySpawnerList()
        {
            return EnemySpawner;
        }
    }
    [SerializeField] [NonReorderable] waveContent[] waves;
    int currentWave = 0;


    // Start is called before the first frame update
    void Start()
    {


    }
    void SpawnWave()
    {
        for(int i = 0; i < waves[currentWave].GetEnemySpawnerList().Length; i++)
        {
            Vector3 SpawnPos;
            float xPos = Random.Range(13, 16) + transform.position.x;
            float zPos = Random.Range(-8, 9) + transform.position.z;
            Instantiate(waves[currentWave].GetEnemySpawnerList()[i]);

            SpawnPos = new Vector3(xPos, 0, zPos);
        }
    }
}
