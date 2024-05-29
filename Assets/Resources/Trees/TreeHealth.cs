using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHealth : MonoBehaviour
{
    public float maxHealth = 100;
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
    public void PlayerClickedThis()
    {
        Debug.Log("hi i am groot");
        TakeDamage(2);
        Debug.Log("TREE HEALTH: " + health.ToString());
    }
}
