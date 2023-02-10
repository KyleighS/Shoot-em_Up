using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float force;

     // Start is called before the first frame update
     void Start()
     {
         rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
     }

     // Update is called once per frame
     void Update()
     {

     }

}
