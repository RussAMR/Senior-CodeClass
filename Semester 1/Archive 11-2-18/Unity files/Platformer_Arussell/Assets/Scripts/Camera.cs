using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{




    float time = 1000;
    Vector3 goalvector = new Vector3();
    public GameObject character;
    float Hspeed = 3f;
    float Vspeed = 1.2f;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        goalvector = new Vector3(character.transform.position.x, character.transform.position.y, -10);
        goalvector = new Vector3(character.GetComponent<Rigidbody2D>().velocity.x, character.GetComponent<Rigidbody2D>().velocity.y, 0);
        Vector3 velocity = goalvector - transform.position;
        transform.position += new Vector3(velocity.x * Time.deltaTime * Hspeed, velocity.y * Time.deltaTime * Vspeed, 0);
       
        
    }
}
