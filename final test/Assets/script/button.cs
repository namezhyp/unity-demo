using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    GameObject enemy,boat,torpedo;
    void Start()  
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void gameStart()
    {
        GameObject test = GameObject.Find("����");
        mainGame main = test.GetComponent<mainGame>();
        main.start = true;  //�޸����ؽű��ڵ���Ϸ״̬

        Debug.Log("��Ϸ��ʼ");

        //enemy = GameObject.Find("enemy");
        //boat = GameObject.Find("boat");
        //torpedo = GameObject.Find("torpedo");

        test.GetComponent<bacgControl>().enabled = true;   //���������ű�
        test.GetComponent<enemyControl>().enabled = true;
        //enemy.GetComponent<enemy>().enabled = true;
        //boat.GetComponent<boat>().enabled = true;    
        //torpedo.GetComponent<torpedo>().enabled = true;

        main.setPosition(); //�޸Ĵ�ֻλ��

        test.GetComponent<AudioSource>().Play();  //��ʼ��������

        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);


    }

}
