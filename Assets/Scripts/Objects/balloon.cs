using Unity.VisualScripting;
using UnityEngine;

public class balloon : MonoBehaviour
{


    public float Speed;
   
    public SpriteRenderer sp;
    public int score;
    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();    
        score = Gamemanager.instance.score;
    }
    public void Hideballoon()
    {
        sp.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void Showballoon()
    {
        sp.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Update()
    {
       
        BallMovement();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);
            if(hit.collider != null && hit.collider.gameObject == gameObject)
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
        else if (score > 20 && score <= 60)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 2f, 0);
        }
        else if (score > 60 && score <= 100)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 2.5f, 0);
        }
         else if (score > 100)
        {
            transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime * 3f, 0);
        }
    }
}
