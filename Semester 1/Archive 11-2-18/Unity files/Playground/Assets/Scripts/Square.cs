using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    [SerializeField]
    float speed = 1f;
    float timer = 1f;
    float time_to_reach = 1f;
    Vector3 Velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        
    }

    // Update is called once per frame
    void Update()
    {
        Velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + 200 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Velocity += lookatdirection(transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Velocity -= lookatdirection(transform.eulerAngles.z);
        }

        Velocity.Normalize();
        transform.position += Velocity * Time.deltaTime * speed;

        
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity  = lookatdirection(transform.eulerAngles.z);
            newBall.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f,1f));

        }
        timer = 0f;
        time_to_reach = 5f;
        timer += Time.deltaTime;
        if (timer < time_to_reach)
        {
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        timer = 0f;




    }
    void movementwasd()
    {
        Velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75)
            {
                Velocity += Vector3.left;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.75)
            {
                Velocity += Vector3.right;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 1)
            {
                Velocity += Vector3.up;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                Velocity -= Vector3.down;
            }
        }
    }
    public Vector3 lookatdirection(float eulerAngels2)
    {
        return new Vector3(Mathf.Cos(eulerAngels2 * Mathf.Deg2Rad), Mathf.Sin(eulerAngels2 * Mathf.Deg2Rad), 0);
    }
}
