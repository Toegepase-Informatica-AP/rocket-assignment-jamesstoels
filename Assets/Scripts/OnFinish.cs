﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFinish : MonoBehaviour
{
    // Start is called before the first frame update
    RocketMove rocket;
    void Start()
    {
        rocket = FindObjectOfType<RocketMove>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rocket.finished = true;
        }
    }
}
