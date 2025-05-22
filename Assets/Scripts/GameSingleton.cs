using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameSingleton : MonoBehaviour
{
    public static GameSingleton Instance;

    public Button audioButton;
    public Sprite playSprite, muteSprite;
    public AudioSource audioSource;
    public Slider audioSlider;
    public GameObject pausePanel;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSlider.value = audioSource.volume;
    }

    public void AudioToggle()
    {
        if (audioButton.image.sprite.name == playSprite.name)
        {
            audioButton.image.sprite = muteSprite;
            audioSource.volume = 0;
            audioSlider.value = 0;
        }
        else
        {
            audioButton.image.sprite = playSprite;
            audioSource.volume = 1f;
            audioSlider.value = 1f;
        }
    }

    public void OnSliderValueChange(float value)
    {
        audioSource.volume = value;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(!pausePanel.activeInHierarchy);
        }
    }

}
