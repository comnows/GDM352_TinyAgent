using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    public float currentTime = 0f;
    public float startingTime = 5f;

    private int currentScene;

    bool isTimeRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        currentTime = startingTime;
        isTimeRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimeRunning)
        {
            if(currentTime > 0)
            {
                currentTime -= 1 * Time.deltaTime;
                timerText.text = currentTime.ToString("0");
            }
            else
            {
                currentTime = 0;
                isTimeRunning = false;
            }
        }
        else
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
