﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelletscrpt : MonoBehaviour
{
    [SerializeField]
    string text;
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
            Destroy(GameObject.Find(text));
            Destroy(gameObject);
        }
    }
}