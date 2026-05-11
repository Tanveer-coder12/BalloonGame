using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BalloonManager : MonoBehaviour
{
    public int Count = 0;
    public GameObject Life1, Life2, Life3;
    public GameObject uimanager;
    public Text Highscore;

    public int HighscoreCount;

    public void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Balloon")
        {
            Count++;
            if (Count == 1)
            {
                Life3.SetActive(false);
            }
            else if (Count == 2)
            {
                Life2.SetActive(false);
            }
            else if (Count == 3)
            {
                Life1.SetActive(false);
            }
            Destroy(collision.gameObject);
            if (Count >= 3)
            {
                foreach (GameObject balloon in GameObject.FindGameObjectsWithTag("Balloon"))
                {
                    Destroy(balloon);
                }
                HighscoreCount = PlayerPrefs.GetInt("HighScore", 0);
                Highscore.text = "HighScore : " + HighscoreCount;
                uimanager.GetComponent<UiManager>().GameOverPanel.SetActive(true);
                uimanager.GetComponent<UiManager>().PauseButton.SetActive(false);
                Time.timeScale = 0f;

            }
        }
    }
}
