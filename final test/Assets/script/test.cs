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
        if(Input.GetMouseButtonDown(0))  //�ж�����Ƿ�㵽�˸�������
        {
            Vector3 mouseDown = Camera.main.ScreenToViewportPoint(Input.mousePosition);  //�˲��ּ��������Ŀ�����
            mouseDown.z = 0;
            float distance = (mouseDown - this.transform.position).magnitude;
            if(distance<2)
            {
                AudioSource audio = GetComponent<AudioSource>();//��갴�£���������
                audio.PlayOneShot(audio.clip);    //playoneshot  �¿�һ�����ţ���ǰ����������ͻ����ͻ

                /*  if(!audio.isplaying)  //����ͬʱ����
                 *  {
                 *      audio.play();
                 *   }
                 *      */

            }
        }
    }
}
