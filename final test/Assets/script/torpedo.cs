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
        float step = 2.0f * Time.deltaTime;   //����ǰ��
        transform.Translate(0,step,0,Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);  //�ɳ���Ļ�Ի�
        if(sp.y>Screen.height)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("enemy"))    //���������ǵ��˾�һ��ը��
        {
            Debug.Log("�ӵ��Ӵ��о�");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            GameObject main = GameObject.Find("����");  //�������ؽű��ĺ������Ʒ�
            mainGame add = main.GetComponent<mainGame>();  //ʵ����һ��add���ڻ�ȡ���
            add.AddScore();
        }
    }
}
