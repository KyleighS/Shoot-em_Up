using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRender;


    void Update()
    {
        bgRender.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
