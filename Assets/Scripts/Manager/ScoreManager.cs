using UnityEngine;
using TMPro; // TextMeshPro ke liye

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        amount += 1;
        scoreText.text = "Score: " + amount;
    }
}