using UnityEngine;
using System.Collections;
using TMPro;

public class Movement : MonoBehaviour
{
    public Transform[] lanePositions;
    public float transitionDuration = 0.2f;
    public TimerScript timerScript;
    public int timeAdd;
    public AudioSource audioSource;
    public TextMeshProUGUI tmp;

    private int currentLane = 1;
    private Coroutine transitionCoroutine;
    public int bottles = 0;
    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;

    static string score;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bottles = 0;
        UpdateBottleCounter();
    }

    void Update()
    {
        CheckSwipe();
    }
    void CheckSwipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fingerDownPosition = Input.mousePosition;
            fingerUpPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            fingerUpPosition = Input.mousePosition;
            DetectSwipe();
        }
    }

    void DetectSwipe()
    {
        if (Mathf.Abs(fingerUpPosition.x - fingerDownPosition.x) > Mathf.Abs(fingerUpPosition.y - fingerDownPosition.y))
        {
            if (fingerUpPosition.x - fingerDownPosition.x > 0)
            {
                // Swipe Right
                SwitchLane(currentLane + 1);
            }
            else if (fingerUpPosition.x - fingerDownPosition.x < 0)
            {
                // Swipe Left
                SwitchLane(currentLane - 1);
            }
        }
    }

    void SwitchLane(int targetLaneIndex)
    {
        if (targetLaneIndex == currentLane || targetLaneIndex < 0 || targetLaneIndex >= lanePositions.Length)
            return;

        if (transitionCoroutine != null)
            StopCoroutine(transitionCoroutine);

        Vector3 targetPosition = new Vector3(lanePositions[targetLaneIndex].position.x, transform.position.y, transform.position.z);
        transitionCoroutine = StartCoroutine(MoveToLaneCoroutine(targetPosition));
        currentLane = targetLaneIndex;
    }

    IEnumerator MoveToLaneCoroutine(Vector3 targetPosition)
    {
        float elapsedTime = 0;
        Vector3 startPosition = transform.position;

        while (elapsedTime < transitionDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
    }

    void IncreaseTimer()
    {
        if (timerScript != null)
        {
            timerScript.AddTime(timeAdd);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottle") && gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            bottles++;
            UpdateBottleCounter();
            IncreaseTimer();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Bottle") && gameObject.CompareTag("End"))
        {
            Destroy(collision.gameObject);
        }
    }

    void UpdateBottleCounter()
    {
        if (tmp != null)
        {
            tmp.text = bottles.ToString();
        }
    }
}
