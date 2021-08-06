using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOutScriptHitEffect : MonoBehaviour
{
    private Color imageCol;
    public float fadeSpeedMultiplier;
    private float alpha;

    private void Start()
    {
        imageCol = GetComponent<Image>().color;
        alpha = imageCol.a;
    }

    private void Update()
    {
        FadeOut();
    }

    private void FadeOut()
    {
        if (alpha <= 0)
        {
            Destroy(gameObject);
        }
        alpha -= Time.deltaTime * fadeSpeedMultiplier;
        GetComponent<Image>().color = new Color(imageCol.r, imageCol.b, imageCol.g, alpha);
        Debug.Log(alpha);
    }
}
