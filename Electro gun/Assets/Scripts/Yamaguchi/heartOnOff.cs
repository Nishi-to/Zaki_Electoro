using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartOnOff : MonoBehaviour
{
    [SerializeField] GameObject heartImage1;
    [SerializeField] GameObject heartImage2;
    [SerializeField] GameObject heartImage3;
    [SerializeField] playerLife life;

    // Start is called before the first frame update
    void Start()
    {
        heartImage1.SetActive(true);
        heartImage2.SetActive(true);
        heartImage3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(life.life == 3)
        {
            heartImage1.SetActive(true);
            heartImage2.SetActive(true);
            heartImage3.SetActive(true);
        }

        if (life.life == 2)
        {
            heartImage1.SetActive(true);
            heartImage2.SetActive(true);
            heartImage3.SetActive(false);
        }

        if (life.life == 1)
        {
            heartImage1.SetActive(true);
            heartImage2.SetActive(false);
            heartImage3.SetActive(false);
        }

        if (life.life == 0)
        {
            heartImage1.SetActive(false);
            heartImage2.SetActive(false);
            heartImage3.SetActive(false);
        }
    }
}
