using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audio;
    private float defaultPitch;
    public static GameManager Instance;
    private void Start()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public void PauseMusic()
    {
        audio.pitch = 0;
    }
    public void UnPauseMusic()
    {
        audio.pitch = defaultPitch;
    }
}
