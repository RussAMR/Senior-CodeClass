using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_plat : MonoBehaviour
{
    [SerializeField]
    float speed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, speed, 0));
        }
    }
}

