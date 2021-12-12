using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject EndGamePanel;
    public GameObject ControllerPanel;

    public Collider2D Blockcollider;
    
    private void Update() 
    {
        if(GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            Blockcollider.enabled = false;
        }
    }
    private void EndLevel()
    {
        EndGamePanel.SetActive(true);
        ControllerPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            EndLevel();
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
