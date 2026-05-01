using System.Collections;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject Balloonpref;
    public Transform spawnpos;
    public BalloonManager balloonManager;
    public GameObject gameOverPanel;
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

}
