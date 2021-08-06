using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectDeley : MonoBehaviour
{
    public float deley;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deley);
    }
}
