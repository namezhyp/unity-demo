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
        GameObject test = GameObject.Find("主控");
        mainGame main = test.GetComponent<mainGame>();
        main.start = true;  //修改主控脚本内的游戏状态

        Debug.Log("游戏开始");

        //enemy = GameObject.Find("enemy");
        //boat = GameObject.Find("boat");
        //torpedo = GameObject.Find("torpedo");

        test.GetComponent<bacgControl>().enabled = true;   //激活其他脚本
        test.GetComponent<enemyControl>().enabled = true;
        //enemy.GetComponent<enemy>().enabled = true;
        //boat.GetComponent<boat>().enabled = true;    
        //torpedo.GetComponent<torpedo>().enabled = true;

        main.setPosition(); //修改船只位置

        test.GetComponent<AudioSource>().Play();  //开始播放音乐

        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);


    }

}
