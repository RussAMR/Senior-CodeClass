using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow_Player : MonoBehaviour {

    Vector3 goalvector = new Vector3();
    public GameObject character;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - character.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = character.transform.position + offset;
    }
}
