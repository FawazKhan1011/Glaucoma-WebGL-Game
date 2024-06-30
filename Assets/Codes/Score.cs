using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class SecondSceneScript : MonoBehaviour
{
    public TextMeshProUGUI points;

    void Start()
    {
        // Retrieve the text from PlayerPrefs and set it to tmpInSecondScene
        string savedText = PlayerPrefs.GetString("Score", "0");
        if (!string.IsNullOrEmpty(savedText))
        {
            points.text = savedText;
        }
    }
}
