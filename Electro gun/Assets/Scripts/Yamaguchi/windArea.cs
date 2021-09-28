// playerが風の中に入った時に風の流れる方向にplayerが引っ張られる

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

        // 風の中いるとplayerを風で押し出す力が働く
        if (windFlag)
        {
            rb.AddForce(windForce, ForceMode.Force);
        }
    }

    // playerと風のエリアの衝突判定
    void OnTriggerEnter(Collider col)
    {
        // playerが風の中にいるかどうか
        if (col.gameObject.tag == "windArea")
        {
            //this.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            windFlag = true;
            Debug.Log("風の中");
            Debug.Log(windFlag);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "windArea")
        {
            windFlag = false;
            Debug.Log("風の外");
        }
    }
}
