using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        // transform.position = Camera.main.ScreenToWorldPoint(pos);
        transform.position = pos;
    }
}
