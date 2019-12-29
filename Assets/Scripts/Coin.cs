﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Purse purse;
        if(purse = other.GetComponent<Purse>())
        {
            purse.AddCoin();

            Destroy(gameObject);
        }
    }
}