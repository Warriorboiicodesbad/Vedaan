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
        ResetTimer();
        StartTimer(); // Start the timer for testing purposes
    }

    void Update()
    {
        if (isRunning)
        {
            currentTime += (isCountingDown ? -1 : 1) * Time.deltaTime;

            if (isCountingDown && currentTime < 0)
            {
                currentTime = 0;
                isRunning = false;
                GameData.OnTimerOver.Invoke();
            }

            UpdateTimerText();
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        currentTime = timeInSeconds;
        UpdateTimerText();
    }

    public void SetTime(float newTime)
    {
        timeInSeconds = newTime;
        ResetTimer();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}"; // Display in MM:SS format
    }
}
