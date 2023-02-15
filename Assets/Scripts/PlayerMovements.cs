using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public int speed;
    public float zRange;

    // Update is called once per frame
    void Update()
    {
        Vector3 vertical = new Vector3(0.0f, 0.0f, Input.GetAxis("Vertical"));
        transform.position = transform.position + (vertical * Time.deltaTime * speed);

        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

    }

}
