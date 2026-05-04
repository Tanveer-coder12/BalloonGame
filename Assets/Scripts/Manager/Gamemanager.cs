using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public GameObject Balloonpref;
    public Transform spawnpos;
    public static Gamemanager instance;
    public int score;
    public Text Scoretxt;
    public float Spawntime;
    public int Highscore = 0;
    public Text HighScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    { 
        if(instance == null)
        {
            instance = this;
        }
        else{
            Destroy(gameObject);
        }

    }
    

    void Start()

    {
        PlayerPrefs.GetInt("Highscore", 0);
        StartCoroutine(Ballspwaning());
    }
    public IEnumerator Ballspwaning()
    {
        while (true)
        {
            if(score >= 0 && score <= 10)
            {
                Spawntime = 2f;
            }
            else if (score > 10 && score <= 20)
            {
                Spawntime = 1.5f;
            }
            else if (score > 20 && score <= 60)
            {
                Spawntime = 1f;
            }
            else if (score > 60 && score <= 100)
            {
                Spawntime = 0.5f;
            }
            else if (score > 100)
            {
                Spawntime = 0.25f;
            }
            yield return new WaitForSeconds(Spawntime);
            float randomrange = Random.Range(-2.3f, 2.3f);

           
            Instantiate(Balloonpref, spawnpos.transform.position = new Vector2(randomrange,spawnpos.transform.position.y), Quaternion.identity);


        }
    }

    public void addscore()
    {
        
        score += 1;

        Scoretxt.text = "Score: " + score;
        if(score > Highscore)
            {
                Highscore = score;
                PlayerPrefs.SetInt("Highscore", Highscore);
                HighScore.text = "Highscore: " + Highscore;
                PlayerPrefs.Save();

        }
    }
   
}