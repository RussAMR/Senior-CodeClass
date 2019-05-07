using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if(Input.GetKeyDown(KeyCode.Delete))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown(KeyCode.Minus))
        {
            transform.position = new Vector3(0, .62f, 0);//(where you want to teleport)
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Tele")
        {
                transform.position = new Vector3(0, .62f, 0);//(where you want to teleport)
            
        }
    }

}
