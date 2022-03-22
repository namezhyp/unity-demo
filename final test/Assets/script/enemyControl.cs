using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Sprite[] images;  //为了实现更换敌人外观随机出现
    // Start is called before the first frame update
    //怪物生成，挂在主场景下
    void Start()
    {
        InvokeRepeating("CreateEnemy", 0.1f, 2f); //定时器，注意写在start内就能重复
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()  //产生新敌人
    {
        float x = Random.Range(-2,2);   //只需要指定水平位置就行
        float y = 5;
        GameObject enemyBoat = Instantiate(enemyPrefab);
        enemyBoat.transform.position = new Vector3(x, y, 0);
        enemyBoat.transform.eulerAngles = new Vector3(0,0,-175);

        int i = Random.Range(0,images.Length);  //注意含头不含尾         //随机换敌人贴图
        SpriteRenderer renderer=enemyBoat.GetComponent<SpriteRenderer>();  
        renderer.sprite = this.images[i];
    }
}
