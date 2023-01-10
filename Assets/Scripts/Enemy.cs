using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public GameObject deathEffect;
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    bool luzha = false;


    private void Update ()
    {
        if ((health <= 0) && (luzha == false))
        {
            spriteRenderer.sprite = spriteArray [1];
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            CircleCollider2D col = GetComponent<CircleCollider2D>();
            col.GetComponent<CircleCollider2D>();
            col.enabled = false;
            luzha = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    
}