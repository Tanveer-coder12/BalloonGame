using UnityEngine;

public class CloudDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
