using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{

    public float speed = 0.25f;
    public Transform Player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Player.position, transform.position) > 0)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }
        else
        {
            transform.position += (displacement * speed * Time.deltaTime);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.collider.tag == "Ball")
        {
            Destroy(gameObject); //Deletes the Enemy
        }
    }
}