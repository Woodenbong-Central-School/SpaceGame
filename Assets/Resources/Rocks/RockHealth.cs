using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float health;
    // Start is called before the first frame update
    void Awake()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void TakeDamage(float amount)
    {
        health -= amount;
    }
}
