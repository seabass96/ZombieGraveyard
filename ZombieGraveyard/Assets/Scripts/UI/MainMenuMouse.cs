using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMouse : MonoBehaviour
{
    public GameObject parti;

    //note to future seb--- use a ray thsi cam shit sint working ffs
    private void Update()
    {
        // Camera cam = Camera.main;
        //Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        // Vector3 mousePos = cam.Screen(pos);
        //Vector3 starPos = new Vector3(mousePos.x, mousePos.y, -1);
        //parti.transform.position = starPos;
        //Debug.Log(mousePos);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        parti.transform.position = ray.origin;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(parti, parti.transform.position, Quaternion.identity);
            //parti.SetActive(false);
            //parti.SetActive(true);
        }
    }
}
