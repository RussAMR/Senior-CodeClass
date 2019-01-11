using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public Vector3 velocity = new Vector3(0, 0, 0);
    [SerializeField]
    float speed = .5f;
    float timer = 0f;
    [SerializeField]
    float time_to_reach = 1f;
    // Use this for initialization
    void Start()
    {
        //velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        //if (timer > time_to_reach)
        //{
        //    GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        //    timer = 0;
        //}
        transform.position += velocity * Time.deltaTime * speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject); //Deletes the ball
        }
        if (collision.tag == "Ground")
        {
            Destroy(gameObject); //Deletes the ball
        }
    }

}
