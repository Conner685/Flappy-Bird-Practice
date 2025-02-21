using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool alive = true;
    public Vector3 birdPosition;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
         myRigidbody.velocity = Vector2.up * flapStrength;
        }
        birdPosition = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        alive = false;
        logic.gameOver();
        Destroy(gameObject);
        

    }

}
