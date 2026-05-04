using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public GameObject Balloonpref;
    public Transform spawnpos;
    public static Gamemanager instance;
    public int score = 0;
    public Text Scoretxt;

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
            yield return new WaitForSeconds(2f);
            float randomrange = Random.Range(-2.5f, 2.5f);

           
            Instantiate(Balloonpref, spawnpos.transform.position = new Vector2(randomrange,spawnpos.transform.position.y), Quaternion.identity);


        }
    }
    public void addscore()
    {
        score += 1;
        Scoretxt.text = "Score: " + score;
    }

}
