using System;
using UnityEngine;

public class BalloonManager : MonoBehaviour
{
    public event EventHandler<OnGameOverEventArgs> OnGameOver;
    public class OnGameOverEventArgs : EventArgs {
        public GameObject gameObject;
    }
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
                OnGameOver?.Invoke(this, new OnGameOverEventArgs { gameObject = collision.gameObject });
            }
        }
    }
}
