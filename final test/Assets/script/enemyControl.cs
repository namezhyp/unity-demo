using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Sprite[] images;  //Ϊ��ʵ�ָ�����������������
    // Start is called before the first frame update
    //�������ɣ�������������
    void Start()
    {
        InvokeRepeating("CreateEnemy", 0.1f, 2f); //��ʱ����ע��д��start�ھ����ظ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()  //�����µ���
    {
        float x = Random.Range(-2,2);   //ֻ��Ҫָ��ˮƽλ�þ���
        float y = 5;
        GameObject enemyBoat = Instantiate(enemyPrefab);
        enemyBoat.transform.position = new Vector3(x, y, 0);
        enemyBoat.transform.eulerAngles = new Vector3(0,0,-175);

        int i = Random.Range(0,images.Length);  //ע�⺬ͷ����β         //�����������ͼ
        SpriteRenderer renderer=enemyBoat.GetComponent<SpriteRenderer>();  
        renderer.sprite = this.images[i];
    }
}
