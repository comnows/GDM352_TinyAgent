using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class UIController : MonoBehaviour
{
    public GameObject RevivePanel;
    public GameObject ControllerPanel;
    public GameObject TutorialPanel;
    private int currentScene;
    
    public void EndGame()
    {
        //ControllerPanel.SetActive(false);
        RevivePanel.SetActive(true);
    }

    public void Revive()
    {
        RevivePanel.SetActive(false);
        CountdownTimer countdownTimer = RevivePanel.GetComponent<CountdownTimer>();
        countdownTimer.currentTime = countdownTimer.startingTime;
        //ControllerPanel.SetActive(true);
    }

    public void Skip()
    {
        AnalyticsResult RestartDic = Analytics.CustomEvent("Restart dic" +
        new Dictionary<string, object>
        {
            {"Restart", 1}
        });
        Debug.Log("RestartDic" + RestartDic);
        //currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("SampleScene");
    }

    public void Back()
    {
        //ControllerPanel.SetActive(true);
        TutorialPanel.SetActive(false);
    }
}
