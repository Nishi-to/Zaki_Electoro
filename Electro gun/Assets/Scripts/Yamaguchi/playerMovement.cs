// ���@�̋���

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Rigidbody rb = this.GetComponent<Rigidbody>();
        ////// x,z���W�̈ړ�����
        ////transform.position = (new Vector3(Mathf.Clamp(transform.position.x, -moveRange, moveRange),
        ////    transform.position.y,
        ////    Mathf.Clamp(transform.position.z, -moveRange, moveRange)));

        //Vector3 force1 = new Vector3(0.0f, 0.0f, 5f);    // �͂�ݒ�
        //Vector3 force2 = new Vector3(0.0f, 0.0f, -5f);
        //Vector3 force3 = new Vector3(5f, 0.0f, 0.0f);
        //Vector3 force4 = new Vector3(-5f, 0.0f, 0.0f);

        //// ��Ɉړ�
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(force1, ForceMode.Force);
        //}
        //// ���Ɉړ�
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(force2, ForceMode.Force);
        //}
        //// �E�Ɉړ�
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(force3, ForceMode.Force);
        //}
        //// ���Ɉړ�
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(force4, ForceMode.Force);
        //}

        // ��Ɉړ�
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Force);
            Debug.Log("��");
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(transform.right * speed * Time.deltaTime, ForceMode.Force);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-transform.right * speed * Time.deltaTime, ForceMode.Force);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * speed * Time.deltaTime, ForceMode.Force);
            Debug.Log("��");
        }
    }
}