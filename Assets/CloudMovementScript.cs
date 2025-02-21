using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovementScript : MonoBehaviour
{
    public float cloudSpeed = 5;
    public float cloudKill = -36;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * cloudSpeed) * Time.deltaTime;
        if (transform.position.x < cloudKill)
        {
            Destroy(gameObject);
        }
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 6)
            {
                transform.position = new Vector3 (transform.position.x, Random.Range(-13, 13), 1);
            }
        }

    }
}
