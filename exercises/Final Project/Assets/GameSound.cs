using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip gameS;
    // Start is called before the first frame update
    void Start()
    {
        Sounds.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
