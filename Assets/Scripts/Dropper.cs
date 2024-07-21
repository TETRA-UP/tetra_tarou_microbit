using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //生成されるフルーツを格納する配列を作成


    [SerializeField]
    float speed;
    float defaultPos;
    [SerializeField]
    AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
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
        //変数の中にランダムな数字を格納しておく
        
        //フルーツの生成
        
        audioSource.PlayOneShot(sound);
    }
}