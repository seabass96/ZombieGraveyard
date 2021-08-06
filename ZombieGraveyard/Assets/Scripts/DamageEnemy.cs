using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public ZombieStats zombie;
    public BodyPart bodyPart;

    public void TakeDamage(float damage)
    {
        zombie.TakeDamage(damage, bodyPart);
    }
}
