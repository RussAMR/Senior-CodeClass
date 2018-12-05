using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Scrpt : MonoBehaviour
{

    [SerializeField]
    public List<Vector3> TeleportLocations = new List<Vector3>();
    float jump = 7;
    Vector3 reset = new Vector3(-1.649f, -0.389f, 0);
    [SerializeField]
    float speed = 2f;
    bool Jumpability = true;
    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D ourbody;
    // Use this for initialization
    void Start()
    {
        AudioManager.Instance.PlayOneShot(SoundEffect.Bgm);
        ourbody = GetComponent<Rigidbody2D>();
        GameManager.Instance.MyCharacter = this;
    }
    // Update is called once per frame
    void Update()
    {
        velocity = ourbody.velocity;
        if (Input.GetKeyDown(KeyCode.W) && Jumpability)
        {
            velocity += Vector3.up * jump;
            Jumpability = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump11,.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }
        ourbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -2f, 2f), Mathf.Clamp(velocity.y, -4f, jump), 0);

    }

    public void onclickteleportbutton()
    {
        transform.position = TeleportLocations[Random.Range(0, TeleportLocations.Count)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            Jumpability = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WB"))
        {
            transform.position = reset;
            speed = 6.5f;
        }
    }
    private void Gameover()
    {
     
    }
}
