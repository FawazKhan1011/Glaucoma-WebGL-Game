using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using System;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 60f; // Total time in seconds
    private float timer; // Timer variable
    public TextMeshProUGUI timerText; // Text component to display the timer
    public GameObject EndImage;
    public GameObject blinking;

    // Flickering effect settings
    public float flickerSpeed = 5f; // Speed of flickering
    private float flickerWeight; // Current weight for flickering

    // Intensity transition settings
    public float transitionIntensity = 0.55f; // Intensity at the end of transition
    public float transitionDuration = 5f; // Duration of intensity transition

    void Start()
    {
        timer = totalTime; 
        UpdateTimerDisplay();
    }

    void Update()
    {
        timer -= Time.deltaTime; // Decrement timer by time passed since last frame

        if (timer <= 0f)
        {
            blinking.SetActive(false);
            timer = 0f; // Ensure timer does not go negative
            EndImage.SetActive(true);
            StartCoroutine(Endscene());
        }
        UpdateTimerDisplay(); // Update timer display
        UpdateVignetteIntensity(); // Update vignette intensity based on timer
    }

    IEnumerator Endscene()
    {
        yield return new WaitForSeconds(1.15f);
        SceneManager.LoadScene("End");
    }

    private void WaitForSeconds(float v)
    {
        throw new NotImplementedException();
    }

    void UpdateTimerDisplay()
    {
        // Convert timer value to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        // Update the timer text with the current time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void AddTime(float additionalTime)
    {
        timer += additionalTime;
    }
    void UpdateVignetteIntensity()
    {
        float normalizedIntensity = 1f - Mathf.Clamp01(timer / totalTime);
 
        if (timer < 10f)
        {
            timerText.color = Color.red;
            blinking.SetActive(true);
        }
        // Check if timer is greater than 10 seconds
        else if (timer > 10f)
        {
            timerText.color = Color.black;
            blinking.SetActive(false) ;
        }
    }
}
