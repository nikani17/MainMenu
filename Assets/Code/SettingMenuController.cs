using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenuController : MonoBehaviour
{
    [SerializeField] private Button backToMenuButton;
    [SerializeField] private GameObject mainMenu;

    private void Awake()
    {
        backToMenuButton.onClick.AddListener(OnBackToMenuButtonClicked);
    }

    private void OnBackToMenuButtonClicked()
    {
        mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
