// ���ꂼ��̃p�[�e�B�N�����o�����鏈��(���@�\�B�Ƃ肠�����L�[���͂Ő���)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControll : MonoBehaviour
{
    //private bool rainIsPlaying;       // �X�v�����N���[�̃p�[�e�B�N������
    private bool windIsPlaying;       // ���̃p�[�e�B�N������
    private bool kaminariIsPlaying;   // ���̃p�[�e�B�N������
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
        //// K�ŃX�v�����N���[��ON/OFF
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    rainIsPlaying = !rainIsPlaying;
        //}

        // L�ŕ���ON/OFF
        if (Input.GetKeyDown(KeyCode.L))
        {
            windIsPlaying = !windIsPlaying;
        }

        // O�ŗ���ON/OFF
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
        //    //Debug.Log("�X�v�����N���[�������܂���");
        //}
        //if (!rainIsPlaying)
        //{
        //    rainParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        //    //Debug.Log("�X�v�����N���[���~�܂�܂���");
        //}

        if (windIsPlaying)
        {
            windParticle.Play(true);
            //Debug.Log("���������܂���");
        }
        if (!windIsPlaying)
        {
            windParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            //Debug.Log("�����~�܂�܂���");
        }

        if (kaminariIsPlaying)
        {
            kaminariParticle.Play(true);
            //Debug.Log("�����o�܂���");
        }
        if (!kaminariIsPlaying)
        {
            kaminariParticle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            //Debug.Log("���������܂���");
        }
    }
}
