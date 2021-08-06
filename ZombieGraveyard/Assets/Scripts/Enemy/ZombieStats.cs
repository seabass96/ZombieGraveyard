using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BodyPart { HEAD, BODY }

public class ZombieStats : MonoBehaviour
{
    public int health;
    private BodyPart lastPartHit;
    public void TakeDamage(int damage, BodyPart part)
    {
        health -= damage;
        lastPartHit = part;
        print("HP: " + health);

        if (health <= 0) Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
