using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (collision.collider.tag == "Player")
        {
            do
            {
                counter++;
                counter = counter * Time.deltaTime;
            } while (counter >= 5);
                SceneManager.LoadScene(buildIndex);
            

        }
    }
}
