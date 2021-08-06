using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInventory : MonoBehaviour
{
    enum WeaponType { Pistol, Revolver, Shotgun, Uzi, SMG, Sniper };
    WeaponType currentWeapon;

    void Start()
    {

        currentWeapon = WeaponType.Pistol;

    }

    void Update()
    {

    }
    void ChangeSelectedWeapon()
    {
        currentWeapon++;

        if((int)currentWeapon >= 6)
        {
            currentWeapon = 0;
        }

        print(currentWeapon);
    }
}
