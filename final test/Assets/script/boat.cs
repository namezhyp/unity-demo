using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    public float speed=1.2f;
    public GameObject 鱼雷弹头;

    private float interval = 0.4f;
    private float count = 0;
    private bool startZ;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject test = GameObject.Find("主控");
        mainGame main = test.GetComponent<mainGame>();
        startZ = main.start;  //从主控脚本获取游戏状态

        if (startZ!= false)
        {
            count += Time.deltaTime;   //定时发射子弹
            if (count >= interval)
            {
                count = 0;
                Fire();
            }

            if (Input.GetKey(KeyCode.A) && transform.position.x>-3.2)  //按键处理
            {
                transform.Translate(-0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x<3.2)   //后面的条件用于限制左右防止出界
            {
                transform.Translate(0.1f, 0, 0);
            }


            speed = 0.4f * Time.deltaTime;   //不需要让船前进，让背景后退即可
                                             //Debug.Log("船开了");
                                             //this.transform.Translate(0,speed,0);
                                             //Debug.Log("speed值为"+speed);
        }
    }

    private void Fire()
    {
        GameObject torpedo = Instantiate(鱼雷弹头);

        Vector3 unknown = new Vector3(0,0.4f,0);
        torpedo.transform.position = this.transform.position + unknown;
    }
}
