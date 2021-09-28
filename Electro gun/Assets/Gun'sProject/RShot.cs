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

        Debug.Log("チャージ開始");
        yield return new WaitForSeconds(waitTime);  //n秒待つ
        charged = true;
        Debug.Log("チャージ完了");

    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))     //人差し指のところのトリガーを押したとき
        {
            if (charged == true)
            {
                charged = false;
                
                rb = Instantiate(Bulletpref, shotPoint.position, shotPoint.rotation).GetComponent<Rigidbody>();    //弾を生成する。
                
                rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);    //前方向にbulletSpeedの数字の分一度だけ力を加える。
                StartCoroutine("sleep");    //sleepコルーチンを呼び出し
            }

        }
    }

}
