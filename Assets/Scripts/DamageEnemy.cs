using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public ZombieStats zombie;
    public BodyPart bodyPart;
    public float damage;

    public void TakeDamage()
    {
        zombie.TakeDamage(damage, bodyPart);
    }
}
