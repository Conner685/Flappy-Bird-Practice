using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPartScript : MonoBehaviour
{
    public BirdScript burb;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem part = GetComponent<ParticleSystem>();
        burb = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        transform.position = burb.birdPosition;
        part.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
