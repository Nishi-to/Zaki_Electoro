using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] int time;

    void Update()
    {
            Destroy(this.gameObject, time);     //このスクリプトを適用したオブジェクトをtime秒後に消す
    }
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == "enemy")    //enemyタグのついたオブジェクトが触れたら
        {
            Destroy(gameObject);
        }*/
    }
}
