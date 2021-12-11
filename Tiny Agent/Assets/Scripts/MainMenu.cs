using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject LevelSelectPanel;

    public void Play()
    {
        LevelSelectPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        MenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
    }
}
