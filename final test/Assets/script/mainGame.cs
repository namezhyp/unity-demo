using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainGame : MonoBehaviour
{
    
    public int score = 0;
    public Text scoreText;//ע���������ַ���
    public bool start = false; //�����Ϸ�Ƿ�������

    GameObject enemy, boat, torpedo;
 

    void Start()
    {
        Application.targetFrameRate = 60;
        start=false;

        //һ��ʼ�ȹص��ű�
        //enemy = GameObject.Find("enemy");
        this.GetComponent<bacgControl>().enabled = false;
        this.GetComponent<enemyControl>().enabled = false;
        //enemy.GetComponent<enemy>().enabled = false;
        //boat.GetComponent<boat>().enabled = false;    //���ó�false�޷���ֹ�����У���������Ϊ���¼����
        //torpedo.GetComponent<torpedo>().enabled = false;   //����ʵ�������⵼����������������

        //������������ʱ��Ϊһ��ʼ�����ű���Ӧ�������ûʵ���������ó���ʱ�յ�
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void AddScore()
    {
        score +=1;
        scoreText.text = "" + score;  //�����õ�����text��Ա
    }

    public void setPosition()  //���ô�ֻ�ĳ�ʼλ��
    {
        GameObject boat = GameObject.Find("boat");
        boat.transform.position = new Vector3(0,-2f,0);
        Debug.Log("��ֻ��ʼλ�����");
    }

   
}
