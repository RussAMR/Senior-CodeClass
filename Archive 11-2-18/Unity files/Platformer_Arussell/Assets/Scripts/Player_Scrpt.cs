using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Scrpt : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    [SerializeField]
    public List<Vector3> TeleportLocations = new List<Vector3>();
    float jump = 7;
    Vector3 reset = new Vector3(-1.649f, -0.389f, 0);
    [SerializeField]
    float speed = 6.5f;
    bool Jumpability = true;
    bool Shootability = true;
    bool FacingLeft = false;
    float timer = 1f;
    float timerholder = 1f;
    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D ourbody;
    Animator animatior;
    private SpriteRenderer spriteRenderer;
    public Sprite StandingMan;
    public Sprite StandingMan_1;
    public Sprite StandingMan_2;
    public Sprite StandingMan_3;
    public Sprite StandingMan_4;
    public Sprite StandingMan_5;
    public Sprite StandingMan_6;
    // Use this for initialization
    void Start()
    {
        ourbody = GetComponent<Rigidbody2D>();
        GameManager.Instance.MyCharacter = this;
        AudioManager.Instance.PlayOneShot(SoundEffect.Bgm2);
    }
    // Update is called once per frame
    void Update()
    {
        velocity = ourbody.velocity;
        if (Input.GetKeyDown(KeyCode.W) && Jumpability)
        {
            velocity += Vector3.up * jump;
            Jumpability = false;
            //ChangeTheSprite();
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump11);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
            FacingLeft = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
            FacingLeft = false;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.Space) && Shootability)
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            velocity += lookatdirection(transform.eulerAngles.z);
            if (FacingLeft == false)
            {
                newBall.transform.localRotation = Quaternion.Euler(0, 0, 90);
                newBall.GetComponent<Ball>().velocity = lookatdirection(transform.eulerAngles.z);
                //newBall.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                Shootability = false;
            }
            if (FacingLeft == true)
            {
                newBall.GetComponent<Ball>().velocity = -lookatdirection(transform.eulerAngles.z);
                newBall.transform.localRotation = Quaternion.Euler(0, 0, 270);
                Shootability = false;
            }
        }
        ourbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -4f, 4f), Mathf.Clamp(velocity.y, -4f, jump), 0);
        if (!Shootability)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Shootability = true;
                timer = timerholder;
            }
        }
    }


    public void onclickteleportbutton()
    {
        transform.position = TeleportLocations[Random.Range(0, TeleportLocations.Count)];


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            Jumpability = true;
        if (collision.collider.tag == "Finsih")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WB"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            speed = 6.5f;
        }
    }
    private void Gameover()
    {

    }
    //void ChangeTheSprite()
    //{
    //    if (spriteRenderer.sprite == StandingMan)
    //    {
    //        for (int i = 0; i < 1; i++)
    //        {
    //            spriteRenderer.sprite = StandingMan_2;
    //        }
    //        for (int d = 0; d < 1; d++)
    //        {
    //            spriteRenderer.sprite = StandingMan_3;
    //        }
    //        for (int i = 0; i < 1; i++)
    //        {
    //            spriteRenderer.sprite = StandingMan_1;
    //        }
    //        for (int a = 0; a < 1; a++)
    //        {
    //            spriteRenderer.sprite = StandingMan_4;
    //        }
    //        for (int i = 0; i < 1; i++)
    //        {
    //            spriteRenderer.sprite = StandingMan_5;
    //        }
    //        for (int i = 0; i < 1; i++)
    //        {
    //            spriteRenderer.sprite = StandingMan_6;
    //        }
    //    }
    //    else
    //    {
    //        spriteRenderer.sprite = StandingMan;
    //    }
    //}
    public Vector3 lookatdirection(float eulerAngels2)
    {
        return new Vector3(Mathf.Cos(eulerAngels2 * Mathf.Deg2Rad), Mathf.Sin(eulerAngels2 * Mathf.Deg2Rad), 0);
    }
}
