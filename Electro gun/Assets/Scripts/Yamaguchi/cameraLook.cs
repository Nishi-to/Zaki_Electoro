//カメラがマウスの動きに合わせて動く

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{

    public Transform verRot;
    public Transform horRot;

    static float X_Rotation;
    static float Y_Rotation;

    // Start is called before the first frame update
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // マウス移動でカメラ位置を設定
        X_Rotation = Input.GetAxis("Mouse X");
        Y_Rotation = Input.GetAxis("Mouse Y");

        // カメラ位置
        verRot.transform.Rotate(0, X_Rotation*1.5f, 0);
        horRot.transform.Rotate(-Y_Rotation*1.3f, 0, 0);
    }
}
