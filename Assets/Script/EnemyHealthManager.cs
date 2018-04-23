﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    public int MaxHealth;
    public int CurrentHealth;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);

        }

    }
    public void HurtEnemy(int damagetoGive)
    {
        CurrentHealth -= damagetoGive;
    }
    public void SetMaxhealth()
    {
        CurrentHealth = MaxHealth;
    }
}

