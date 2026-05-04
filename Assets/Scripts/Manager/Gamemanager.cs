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
            else if (score > 20 && score <= 30)
            {
                Spawntime = 1f;
            }
            else if (score > 30 && score <= 40)
            {
                Spawntime = 0.5f;
            }
            else if (score > 40)
            {
                Spawntime = 0.25f;
            }
            yield return new WaitForSeconds(Spawntime);
            float randomrange = Random.Range(-2.5f, 2.5f);

           
            Instantiate(Balloonpref, spawnpos.transform.position = new Vector2(randomrange,spawnpos.transform.position.y), Quaternion.identity);


        }
    }
    public void addscore()
    {
        
        score += 1;

        Scoretxt.text = "Score: " + score;
    }
    public void highscorefunc()
    {
        
    }
}
