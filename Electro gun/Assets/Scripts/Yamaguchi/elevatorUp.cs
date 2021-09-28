using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorUp : MonoBehaviour
{
    bool upFlag;
    public float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        upFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            upFlag = true;
            Debug.Log(upFlag);
        }

        if(upFlag)
        {
            this.transform.position += new Vector3(0, y * Time.deltaTime, 0);
        }

        if (y > 20)
        {
            this.y = 20;
        }
    }
}
