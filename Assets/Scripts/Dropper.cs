using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //���������t���[�c���i�[����z����쐬


    [SerializeField]
    float speed;
    float defaultPos;
    [SerializeField]
    AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
        defaultPos = transform.position.x;
        Pop();
    }

    // Update is called once per frame
    void Update()
    {

        float x = transform.position.x + speed;
        if (x > defaultPos + 5 || x < defaultPos - 5)
        {
            speed *= -1;
        }
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

    }
    public void Pop()
    {
        //�ϐ��̒��Ƀ����_���Ȑ������i�[���Ă���
        
        //�t���[�c�̐���
        
        audioSource.PlayOneShot(sound);
    }
}