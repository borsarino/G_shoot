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
        float rad = Angle * Mathf.Deg2Rad; // �p�x�����W�A���ɕϊ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0); // �����x�N�g�����v�Z
        vec = direction * speed * Time.deltaTime; // ���x�Ǝ��Ԃ��|���Ĉړ��ʂ��v�Z
    }

    private void OnBecameInvisible()
    {
        // ��ʊO�ɍs�����Ƃ��I�u�W�F�N�g������
        Destroy(gameObject);
    }
}
