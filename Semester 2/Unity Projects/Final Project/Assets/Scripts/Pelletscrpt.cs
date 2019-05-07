using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelletscrpt : MonoBehaviour
{
    [SerializeField]
    string text;
    [SerializeField]
    string findme;
    GameObject hiddenblock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (GameObject.Find(findme) == true)
            {
                Debug.Log("Am I active!");
                GameObject.Find(findme).GetComponent<MeshRenderer>().enabled = true;
                Destroy(GameObject.Find(text));
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Active?");
                Destroy(GameObject.Find(text));
                Destroy(gameObject);
            }


        }
        
    }
}
