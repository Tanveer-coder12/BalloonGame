using Unity.VisualScripting;
using UnityEngine;

public class balloon : MonoBehaviour
{


    public float Speed;

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
        transform.Translate(0, Vector2.up.y * Speed * Time.deltaTime, 0);
    }
}
