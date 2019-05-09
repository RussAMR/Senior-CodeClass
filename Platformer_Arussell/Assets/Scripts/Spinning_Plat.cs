using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_Plat : MonoBehaviour
{
    [SerializeField]
    float speed = 4;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.back * speed);
    }
}
