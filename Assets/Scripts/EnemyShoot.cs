using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    float EnemyRange = 20f;
    private float distanceBetweenTarget;
    private NavMeshAgent navMeshAgent;

    [SerializeField]
    private Transform[] laserSpawnPoint;

    [SerializeField]
    private GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetweenTarget = Vector3.Distance(target.position, transform.position);

        if(distanceBetweenTarget <= EnemyRange)
        {
            navMeshAgent.SetDestination(target.position);
        }

        if(distanceBetweenTarget <= navMeshAgent.stoppingDistance)
        {
            foreach(Transform SpawnPonts in laserSpawnPoint)
            {
                Instantiate(laserPrefab, SpawnPonts.position, transform.rotation);
            }
        }
    }
}
