﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallonPalatus : MonoBehaviour
{
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.10f)
        {
            transform.position = startPosition;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "reika")
        {
            Debug.Log("kaka");
            transform.position = startPosition;
        }
    }
}