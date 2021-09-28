using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RShot : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 0;

    [SerializeField] public GameObject Bulletpref;

    [SerializeField] private Transform shotPoint;

    [SerializeField] float waitTime;

    static bool charged = true;

    Rigidbody rb;

    IEnumerator sleep()
    {

        Debug.Log("�`���[�W�J�n");
        yield return new WaitForSeconds(waitTime);  //n�b�҂�
        charged = true;
        Debug.Log("�`���[�W����");

    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))     //�l�����w�̂Ƃ���̃g���K�[���������Ƃ�
        {
            if (charged == true)
            {
                charged = false;
                
                rb = Instantiate(Bulletpref, shotPoint.position, shotPoint.rotation).GetComponent<Rigidbody>();    //�e�𐶐�����B
                
                rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);    //�O������bulletSpeed�̐����̕���x�����͂�������B
                StartCoroutine("sleep");    //sleep�R���[�`�����Ăяo��
            }

        }
    }

}
