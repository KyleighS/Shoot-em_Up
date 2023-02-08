using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShoot : MonoBehaviour
{
    public GameObject laser;
    public Transform laserPos;
    public int laserSpeed;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laser, laserPos.position, Quaternion.identity);
        laser.GetComponent<Rigidbody>().velocity = laserPos.forward * laserSpeed;
    }
}
