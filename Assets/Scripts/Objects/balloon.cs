using Unity.VisualScripting;
using UnityEngine;

public class balloon : MonoBehaviour
{


    public float Speed;
    public int score = 0;

    private void Start()
    {
        score = Gamemanager.instance.score;
    }
    void Update()
    {
        BallMovement();
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {

                Gamemanager.instance.addscore();
                
                Destroy(gameObject);

            }
        }
    }
    public void BallMovement()
    {
        if (score >= 0 && score <= 10)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime, 0);

        }
        else if(score > 10 && score <= 20)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 1.5f, 0);
        }
        else if (score > 20 && score <= 30)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 2f, 0);
        }
        else if (score > 30 && score <= 40)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 2.5f, 0);
        }
         else if (score > 40)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 3f, 0);
        }
    }
}
