using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastPointDelete : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "OffScreen")
        {
            Destroy(gameObject);
        }
    }
}
