// 自機の挙動

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Rigidbody rb = this.GetComponent<Rigidbody>();
        ////// x,z座標の移動制限
        ////transform.position = (new Vector3(Mathf.Clamp(transform.position.x, -moveRange, moveRange),
        ////    transform.position.y,
        ////    Mathf.Clamp(transform.position.z, -moveRange, moveRange)));

        //Vector3 force1 = new Vector3(0.0f, 0.0f, 5f);    // 力を設定
        //Vector3 force2 = new Vector3(0.0f, 0.0f, -5f);
        //Vector3 force3 = new Vector3(5f, 0.0f, 0.0f);
        //Vector3 force4 = new Vector3(-5f, 0.0f, 0.0f);

        //// 上に移動
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(force1, ForceMode.Force);
        //}
        //// 下に移動
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(force2, ForceMode.Force);
        //}
        //// 右に移動
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(force3, ForceMode.Force);
        //}
        //// 左に移動
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(force4, ForceMode.Force);
        //}

        // 上に移動
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 15, ForceMode.Force);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(transform.right * 15, ForceMode.Force);
        }
        // 左に移動
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-transform.right * 15, ForceMode.Force);
        }
        // 下に移動
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * 15, ForceMode.Force);
        }
    }
}