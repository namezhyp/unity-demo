using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    public float speed=1.2f;
    public GameObject ���׵�ͷ;

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
        GameObject test = GameObject.Find("����");
        mainGame main = test.GetComponent<mainGame>();
        startZ = main.start;  //�����ؽű���ȡ��Ϸ״̬

        if (startZ!= false)
        {
            count += Time.deltaTime;   //��ʱ�����ӵ�
            if (count >= interval)
            {
                count = 0;
                Fire();
            }

            if (Input.GetKey(KeyCode.A) && transform.position.x>-3.2)  //��������
            {
                transform.Translate(-0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x<3.2)   //��������������������ҷ�ֹ����
            {
                transform.Translate(0.1f, 0, 0);
            }


            speed = 0.4f * Time.deltaTime;   //����Ҫ�ô�ǰ�����ñ������˼���
                                             //Debug.Log("������");
                                             //this.transform.Translate(0,speed,0);
                                             //Debug.Log("speedֵΪ"+speed);
        }
    }

    private void Fire()
    {
        GameObject torpedo = Instantiate(���׵�ͷ);

        Vector3 unknown = new Vector3(0,0.4f,0);
        torpedo.transform.position = this.transform.position + unknown;
    }
}
