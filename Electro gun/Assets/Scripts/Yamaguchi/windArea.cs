// player�����̒��ɓ��������ɕ��̗���������player������������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windArea : MonoBehaviour
{
    private bool windFlag;

    // Start is called before the first frame update
    void Start()
    {
        windFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();

        Vector3 windForce = new Vector3(60.0f, 0.0f, 0.0f);

        // ���̒������player�𕗂ŉ����o���͂�����
        if (windFlag)
        {
            rb.AddForce(windForce, ForceMode.Force);
        }
    }

    // player�ƕ��̃G���A�̏Փ˔���
    void OnTriggerEnter(Collider col)
    {
        // player�����̒��ɂ��邩�ǂ���
        if (col.gameObject.tag == "windArea")
        {
            //this.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            windFlag = true;
            Debug.Log("���̒�");
            Debug.Log(windFlag);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "windArea")
        {
            windFlag = false;
            Debug.Log("���̊O");
        }
    }
}
