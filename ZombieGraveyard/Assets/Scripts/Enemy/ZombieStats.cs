using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum BodyPart { HEAD, BODY }

public class ZombieStats : MonoBehaviour
{
    public float health;
    private BodyPart lastPartHit;
    public void TakeDamage(float damage, BodyPart part)
    {
        health -= damage;
        lastPartHit = part;
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
