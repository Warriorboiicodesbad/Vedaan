using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TMP_Text timerText; // Assign TextMeshPro - Text component
    public float timeInSeconds = 60f; // Initial time in seconds
    public bool isCountingDown = true; // Set to false for count-up timer
    private bool isRunning = false;

    private float currentTime;

    void Start()
    {
        Debug.Log("Timer initialized.");
        ResetTimer();
        StartTimer(); // Start the timer for testing purposes
    }

    void Update()
    {
        if (isRunning)
        {
            Debug.Log("Timer is running...");
            currentTime += (isCountingDown ? -1 : 1) * Time.deltaTime;

            if (isCountingDown && currentTime < 0)
            {
                currentTime = 0;
                isRunning = false;
                Debug.Log("Timer reached zero and stopped.");
            }

            UpdateTimerText();
        }
    }

    public void StartTimer()
    {
        Debug.Log("Timer started.");
        isRunning = true;
    }

    public void StopTimer()
    {
        Debug.Log("Timer stopped.");
        isRunning = false;
    }

    public void ResetTimer()
    {
        Debug.Log("Timer reset.");
        currentTime = timeInSeconds;
        UpdateTimerText();
    }

    public void SetTime(float newTime)
    {
        Debug.Log($"Time set to {newTime} seconds.");
        timeInSeconds = newTime;
        ResetTimer();
    }

    private void UpdateTimerText()
    {
        Debug.Log($"Updating Timer: {currentTime}");
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}"; // Display in MM:SS format
    }
}
