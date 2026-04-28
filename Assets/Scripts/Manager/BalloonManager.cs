using UnityEngine;

public class BalloonManager : MonoBehaviour
{
    public int Count = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Balloon")
        {
            Count++;
            Destroy(collision.gameObject);
            if(Count>=3)
            {
                
                Time.timeScale = 0f;
            }
        }
    }
}
