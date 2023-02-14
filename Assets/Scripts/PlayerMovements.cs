using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public int speed;
    public float zMinRange;
    public float zMaxRange;

    // Update is called once per frame
    void Update()
    {
        Vector3 vertical = new Vector3(0.0f, 0.0f, Input.GetAxis("Vertical"));
        transform.position = transform.position + (vertical * Time.deltaTime * speed);

        if(transform.position.z < zMinRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMinRange);
        }
    }

}
