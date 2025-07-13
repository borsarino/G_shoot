using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ball_script : MonoBehaviour
{
    public float speed = 1;
    public float Angle = 45;
    private Rigidbody2D rb;
    public GameManager myManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2Dコンポーネントを取得
        float rad = Angle * Mathf.Deg2Rad; // 角度をラジアンに変換
        Vector2 direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)); // 方向ベクトルを計算
        rb.linearVelocity = direction * speed; // 発射速度・角度を設定
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        // 画面外に行ったときオブジェクトを消去
        Destroy(gameObject);
        myManager.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトのタグが"wall"の場合、角度を反転
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject); // "finish"タグのオブジェクトに衝突したら自分を消去
            myManager.GameClear(); // ゲームクリアのメソッドを呼び出す
        }
    }

    /*private void Decidevector()
    {
        float rad = Angle * Mathf.Deg2Rad; // 角度をラジアンに変換
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // 方向ベクトルを計算
        vec = direction * speed * Time.deltaTime; // 速度と時間を掛けて移動量を計算
    }*/
}
