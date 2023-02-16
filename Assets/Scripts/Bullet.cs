using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Scoring.instance.AddPoint();
        }

        Destroy(collision.gameObject);
        Destroy(gameObject);
        if (collision.gameObject.tag == "Last")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
