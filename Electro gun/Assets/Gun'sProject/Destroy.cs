using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] int time;

    void Update()
    {
            Destroy(this.gameObject, time);     //���̃X�N���v�g��K�p�����I�u�W�F�N�g��time�b��ɏ���
    }
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == "enemy")    //enemy�^�O�̂����I�u�W�F�N�g���G�ꂽ��
        {
            Destroy(gameObject);
        }*/
    }
}
