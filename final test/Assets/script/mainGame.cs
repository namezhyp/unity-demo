using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainGame : MonoBehaviour
{
    
    public int score = 0;
    public Text scoreText;//注意它不是字符串
    public bool start = false; //监控游戏是否在运行

    GameObject enemy, boat, torpedo;
 

    void Start()
    {
        Application.targetFrameRate = 60;
        start=false;

        //一开始先关掉脚本
        //enemy = GameObject.Find("enemy");
        this.GetComponent<bacgControl>().enabled = false;
        this.GetComponent<enemyControl>().enabled = false;
        //enemy.GetComponent<enemy>().enabled = false;
        //boat.GetComponent<boat>().enabled = false;    //设置成false无法阻止它运行，可能是因为有事件检测
        //torpedo.GetComponent<torpedo>().enabled = false;   //此外实例化问题导致他们难以起作用

        //这三个不设置时因为一开始三个脚本对应的组件还没实例化，调用出来时空的
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void AddScore()
    {
        score +=1;
        scoreText.text = "" + score;  //这里用的是其text成员
    }

    public void setPosition()  //设置船只的初始位置
    {
        GameObject boat = GameObject.Find("boat");
        boat.transform.position = new Vector3(0,-2f,0);
        Debug.Log("船只初始位置完成");
    }

   
}
