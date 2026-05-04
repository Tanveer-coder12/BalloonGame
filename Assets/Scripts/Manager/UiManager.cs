using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject PauseButton;
    public Text HighScore;
    private void Start()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void PauseGame()
   {
       PausePanel.SetActive(true);  
    PauseButton.SetActive(false);
        
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
        Time.timeScale = 1;
    }
}
