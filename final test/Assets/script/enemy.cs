using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    GameObject target;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("boat");
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 dir = (target.transform.position - transform.position).normalized;  //�˶��������
        float angle = Vector3.SignedAngle(Vector3.left, dir, Vector3.forward);
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 0, angle), 3f);*/
        //transform.LookAt(target.transform,Vector3.forward);

        speed = 0.4f * Time.deltaTime;
        this.transform.Translate(0, -speed, 0,Space.World);
        //Debug.Log("�о�����");

        if(transform.position.y<-7)  //�ɳ���Ļ����Ҫ�Ի�
        {
            Destroy(this.gameObject);
        }
    }
}
