// それぞれのパーティクルが出現する処理(仮機能。とりあえずキー入力で制御)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControll : MonoBehaviour
{
    //private bool rainIsPlaying;       // スプリンクラーのパーティクル制御
    private bool windIsPlaying;       // 風のパーティクル制御
    private bool kaminariIsPlaying;   // 雷のパーティクル制御
    //[SerializeField] ParticleSystem rainParticle;
    [SerializeField] ParticleSystem windParticle;
    [SerializeField] ParticleSystem kaminariParticle;

    // Start is called before the first frame update
    void Start()
    {
        //rainIsPlaying = false;
        windIsPlaying = false;
        kaminariIsPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        //// KでスプリンクラーのON/OFF
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    rainIsPlaying = !rainIsPlaying;
        //}

        // Lで風のON/OFF
        if (Input.GetKeyDown(KeyCode.L))
        {
            windIsPlaying = !windIsPlaying;
        }

        // Oで雷のON/OFF
        if (Input.GetKeyDown(KeyCode.O))
        {
            kaminariIsPlaying = !kaminariIsPlaying;
        }

        Switch();
    }

    public void Switch()
    {
        //if (rainIsPlaying)
        //{
        //    rainParticle.Play(true);
        //    //Debug.Log("スプリンクラーが動きました");
        //}
        //if (!rainIsPlaying)
        //{
        //    rainParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        //    //Debug.Log("スプリンクラーが止まりました");
        //}

        if (windIsPlaying)
        {
            windParticle.Play(true);
            //Debug.Log("風が動きました");
        }
        if (!windIsPlaying)
        {
            windParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            //Debug.Log("風が止まりました");
        }

        if (kaminariIsPlaying)
        {
            kaminariParticle.Play(true);
            //Debug.Log("雷が出ました");
        }
        if (!kaminariIsPlaying)
        {
            kaminariParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            //Debug.Log("雷が消えました");
        }
    }
}
