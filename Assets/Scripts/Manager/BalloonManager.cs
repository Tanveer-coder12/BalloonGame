using System;
using UnityEngine;

public class BalloonManager : MonoBehaviour
{
    
    public int Count = 0;
    public GameObject life1,life2,life3;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Balloon")
        {
            Count++;

            Destroy(collision.gameObject);

            if(Count==1)
                {
                    life3.SetActive(false);
            }
                if(Count==2)
                {
                   life2.SetActive(false);
            }

            if (Count>=3)
            {
                life1.SetActive(false);
                foreach (var balloon in GameObject.FindGameObjectsWithTag("Balloon"))
                {
                    Destroy(balloon);
                }

                Time.timeScale = 0f;
                
            }
        }
    }
}
