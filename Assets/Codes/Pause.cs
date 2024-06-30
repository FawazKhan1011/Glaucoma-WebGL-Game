using UnityEngine;
using UnityEngine.Video;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public AudioSource audioSource;
    void Start()
    {
        Time.timeScale = 1;
        // Assign the VideoPlayer component if it's not assigned already
        if (videoPlayer == null)
        {
            videoPlayer = FindObjectOfType<VideoPlayer>();
        }
        if (audioSource == null)
        {
            audioSource = FindObjectOfType<AudioSource>();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        if (videoPlayer != null && videoPlayer.isPlaying)
        {
            videoPlayer.Pause(); // Pause the video player
        }
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Pause(); // Pause the audio
        }
        pauseScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        if (videoPlayer != null)
        {
            videoPlayer.Play(); // Resume the video player
        }
        if (audioSource != null)
        {
            audioSource.UnPause(); // Resume the audio
        }
        pauseScreen.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
