using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform endOfGun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        print("FIRE");
        //raycast forward and get object hit
        //Physics.Raycast(endOfGun.position, Vector3.forward);
        Debug.DrawRay(endOfGun.position, Vector3.forward, Color.red, 3.0f);

    }
}
