using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button startGameButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject settingsMenu;

    private void Awake()
    {
        startGameButton.onClick.AddListener(OnStartGameButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void OnStartGameButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    
    private void OnSettingsButtonClicked()
    {
        settingsMenu.SetActive(true);
        gameObject.SetActive(false);
    }

    private void OnCreditsButtonClicked()
    {
        creditsMenu.SetActive(true);
        gameObject.SetActive(false);
    }

    private void OnExitButtonClicked()
    {
        Application.Quit();
        Debug.Log("Exit Clicked");
    }
}
