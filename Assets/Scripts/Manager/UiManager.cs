using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class UiManager : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject PauseButton;
    public GameObject GameOverPanel;
     balloon []balloonmove;
    private void Start()
    {
        balloonmove = FindObjectsByType<balloon>();
        GameOverPanel.SetActive(false); 
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void PauseGame()
   {
        PausePanel.SetActive(true);  
        PauseButton.SetActive(false);
        foreach (balloon bal in FindObjectsByType<balloon>(FindObjectsSortMode.None))
        {
            bal.Hideballoon();
        }
        Time.timeScale = 0;

   }
   public void HomeButton()
    {
        PausePanel.SetActive(false);
        Application.Quit();
    }
    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
        foreach (balloon bal in FindObjectsByType<balloon>(FindObjectsSortMode.None))
        {
           bal.Showballoon();
        }
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
       SceneManager.LoadScene("SampleScene");
    }
}
