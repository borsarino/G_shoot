using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ball_script : MonoBehaviour
{
    public float speed = 1;
    public float Angle = 45;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D�R���|�[�l���g���擾
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector2 direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)); // �����x�N�g�����v�Z
        rb.linearVelocity = direction * speed; // ���ˑ��x�E�p�x��ݒ�
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
        // ��ʊO�ɍs�����Ƃ��I�u�W�F�N�g������
        Destroy(gameObject);
    }

    /*private void Decidevector()
    {
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // �����x�N�g�����v�Z
        vec = direction * speed * Time.deltaTime; // ���x�Ǝ��Ԃ��|���Ĉړ��ʂ��v�Z
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // �����x�N�g�����v�Z
        vec = direction * speed * Time.deltaTime; // ���x�Ǝ��Ԃ��|���Ĉړ��ʂ��v�Z
    }*/
}
