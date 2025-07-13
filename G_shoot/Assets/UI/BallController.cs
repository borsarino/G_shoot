using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameManager myManager;

    void OnBecameInvisible()
    {
        Destroy(gameObject); // ボールが画面外に出たらゲームオーバー
        myManager.GameOver();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
            myManager.GameClear();
        }
    }
}