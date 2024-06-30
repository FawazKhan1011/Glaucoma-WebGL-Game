using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class lvlloader : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject cog;
    public Slider slider;
    public Button button;

    public void ChangeScene()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    IEnumerator LoadSceneCoroutine()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);
        cog.SetActive(true);
        button.interactable = false;
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f); // Calculate progress dynamically
            slider.value = progress;

            // Check if progress is very close to 1 before completing loading
            if (asyncLoad.progress >= 0.9f)
            {
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }

        // Set the slider to 90% completion to indicate loading is done
        slider.value = 0.9f;
    }
}
