using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flushController : MonoBehaviour
{
    Image img;

    [SerializeField]
    playerLife playerlife;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        Flush();
    }

    void Flush()
    {
        if (playerlife.damageFlag)
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
            Debug.Log("flush");
        }
    }
}
