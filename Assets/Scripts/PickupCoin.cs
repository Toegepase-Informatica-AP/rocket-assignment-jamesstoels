using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    public int points;
    RocketMove rocket;
    private void Start()
    {
        rocket = FindObjectOfType<RocketMove>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {                
            rocket.points += points;
            Destroy(gameObject);
        }
    }
}
