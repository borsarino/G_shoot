using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ball_script : MonoBehaviour
{
    public float speed;
    public float Angle;
    Vector3 vec;
    private Rigidbody myRigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Decidevector()
    {
        float rad = Angle * Mathf.Deg2Rad; // 角度をラジアンに変換
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // 方向ベクトルを計算
        vec = direction * speed * Time.deltaTime; // 速度と時間を掛けて移動量を計算
    }

    private void OnBecameInvisible()
    {
        // 画面外に行ったときオブジェクトを消去
        Destroy(gameObject);
    }
}
