using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthSystem : MonoBehaviour
{
    //60 percent

    //75 percent

    //85 percent

    public Sprite bloodv1;
    public Sprite bloodv2;
    public Sprite bloodv3;
    public GameObject image;

    [Range(0,1)]
    public float healthPercentage = 0.5f;

    private Color bloodColor;
    public float multiplyer;

    private void Start()
    {
        bloodColor = image.GetComponent<Image>().color;
    }
    private void Update()
    {
        updateScreenOverlay();
    }

    private void updateScreenOverlay()
    {
        if(healthPercentage > 0.85)
        {
            image.GetComponent<Image>().enabled = true;
            image.GetComponent<Image>().sprite = bloodv3;
            Alphapulse();
        }
        else if(healthPercentage > 0.75)
        {
            image.GetComponent<Image>().enabled = true;
            image.GetComponent<Image>().sprite = bloodv2;
            Alphapulse();
        }
        else if(healthPercentage > 0.60)
        {
            image.GetComponent<Image>().enabled = true;
            image.GetComponent<Image>().sprite = bloodv1;
            Alphapulse();
        }
        else
        {
            image.GetComponent<Image>().enabled = false;
        }
    }

    private void Alphapulse()
    {
        float alpha = Mathf.Abs( Mathf.Sin(Time.realtimeSinceStartup * multiplyer));
        bloodColor = new Color(bloodColor.r, bloodColor.b, bloodColor.g, alpha);
        image.GetComponent<Image>().color = bloodColor;
    }

}
