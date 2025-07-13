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
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D�R���|�[�l���g���擾
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector2 direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)); // �����x�N�g�����v�Z
        rb.linearVelocity = direction * speed; // ���ˑ��x�E�p�x��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        // ��ʊO�ɍs�����Ƃ��I�u�W�F�N�g������
        Destroy(gameObject);
        myManager.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂����I�u�W�F�N�g�̃^�O��"wall"�̏ꍇ�A�p�x�𔽓]
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject); // "finish"�^�O�̃I�u�W�F�N�g�ɏՓ˂����玩��������
            myManager.GameClear(); // �Q�[���N���A�̃��\�b�h���Ăяo��
        }
    }

    /*private void Decidevector()
    {
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // �����x�N�g�����v�Z
        vec = direction * speed * Time.deltaTime; // ���x�Ǝ��Ԃ��|���Ĉړ��ʂ��v�Z
    }*/
}
