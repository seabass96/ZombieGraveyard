using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitEffect : MonoBehaviour
{
    public Sprite[] blood;
    public GameObject hitImage;
    public bool showHit;
    private Sprite lastImage;

    private void Update()
    {
        ShowHit();
    }

    private void ShowHit()
    {
        if(showHit)
        { 
            GameObject instance = Instantiate(hitImage, gameObject.transform);
            instance.GetComponent<Image>().sprite = setSprite();
            showHit = false;
        }
    }

    private Sprite setSprite()
    {
        Sprite sprite = blood[Random.Range(0, blood.Length)];
        if (sprite == lastImage)
        {
            setSprite();
        }

        lastImage = sprite;
        return sprite;
    }

}
