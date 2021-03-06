using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuButtons : MonoBehaviour
{
    public GameObject startButtton;

    public int bigTextSize;
    private int textSize;

    public Color onClickColor;
    private Color startButtonColor;


    private void Start()
    {
        textSize = startButtton.transform.GetChild(0).GetComponent<Text>().fontSize;
        startButtonColor = startButtton.transform.GetChild(0).GetComponent<Text>().color;
    }

    public void MakeTextBig(GameObject button)
    {
        button.transform.GetChild(0).GetComponent<Text>().fontSize = bigTextSize;
    }

    public void MakeTextNormal(GameObject button)
    {
        button.transform.GetChild(0).GetComponent<Text>().fontSize = textSize;
    }

    public void OnClickColor(GameObject button)
    {
        button.transform.GetChild(0).GetComponent<Text>().color = onClickColor;
    }

    public void ReturnToOriginalColor(GameObject button)
    {
        button.transform.GetChild(0).GetComponent<Text>().color = startButtonColor;
    }

#region button functionality
    public void StartGame()
    {
        SceneManager.LoadScene(1); //change when we set this up
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void OpenSettingsMenu()
    {
        GetComponent<Animator>().SetTrigger("ShowSettings");
    }

    public void BackButton()
    {
        GetComponent<Animator>().SetTrigger("HideSettings");
    }

 #endregion
}
