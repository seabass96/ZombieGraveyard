using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMouse : MonoBehaviour
{
    public GameObject parti;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 starPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
                Camera.main.ScreenToWorldPoint(Input.mousePosition).y, parti.transform.position.z);
            parti.transform.position = starPos;
            parti.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            parti.SetActive(false);
        }
    }
}
