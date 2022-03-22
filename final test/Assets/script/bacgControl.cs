using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacgControl : MonoBehaviour
{
    // Start is called before the first frame update
    Transform bg1, bg2; //不使用gameobject，移动transform就够了
    void Start()
    {
        bg1 = GameObject.Find("/背景/海面").transform;
        bg2 = GameObject.Find("/背景/海面 (1)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float yspeed = Time.deltaTime * 0.4f;
        bg1.Translate(0,-yspeed,0);
        bg2.Translate(0, -yspeed, 0);

        if(bg1.position.y<-10)
        {
            bg1.Translate(0,20,0);
            //Debug.Log("1上翻");
        }

        if (bg2.position.y < -9)
        {
            bg2.Translate(0, 20, 0);
            //Debug.Log("2上翻");
        }
    }
}
