using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torpedo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = 2.0f * Time.deltaTime;   //鱼雷前进
        transform.Translate(0,step,0,Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);  //飞出屏幕自毁
        if(sp.y>Screen.height)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("enemy"))    //攻击到的是敌人就一块炸掉
        {
            Debug.Log("子弹接触敌军");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            GameObject main = GameObject.Find("主控");  //调用主控脚本的函数来计分
            mainGame add = main.GetComponent<mainGame>();  //实例化一个add用于获取组件
            add.AddScore();
        }
    }
}
