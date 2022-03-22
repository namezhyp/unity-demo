using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))  //判断鼠标是否点到了该物体上
        {
            Vector3 mouseDown = Camera.main.ScreenToViewportPoint(Input.mousePosition);  //此部分计算鼠标与目标距离
            mouseDown.z = 0;
            float distance = (mouseDown - this.transform.position).magnitude;
            if(distance<2)
            {
                AudioSource audio = GetComponent<AudioSource>();//鼠标按下，播放音乐
                audio.PlayOneShot(audio.clip);    //playoneshot  新开一个播放，让前后声音不冲突不冲突

                /*  if(!audio.isplaying)  //不会同时播放
                 *  {
                 *      audio.play();
                 *   }
                 *      */

            }
        }
    }
}
