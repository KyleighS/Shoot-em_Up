using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShoot : MonoBehaviour
{
    public Transform laserSpawnPoint;
    public GameObject laserPrefab;
    public float speed = 10;

    private float countDown = 4;

    void Update()
    {
        countDown -= Time.deltaTime;

        if (countDown <= 0)
        {
            var bullet = Instantiate(laserPrefab, laserSpawnPoint.position, laserSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = -laserSpawnPoint.right * speed;

            countDown = 4;
        }
    }
}