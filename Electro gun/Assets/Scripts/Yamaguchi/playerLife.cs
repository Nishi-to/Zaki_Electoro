using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLife : MonoBehaviour
{
    public int life;

    public bool damageFlag;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        damageFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        LifeDown();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            damageFlag = true;
        }
    }

    void LifeDown()
    {
        if (damageFlag == true)
        {
            life--;
            damageFlag = false;
        }
    }
}
