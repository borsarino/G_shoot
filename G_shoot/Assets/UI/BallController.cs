using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameManager myManager;

    void OnBecameInvisible()
    {
        myManager.GameOver();
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            myManager.GameClear();
            Destroy(gameObject);
        }
    }
}