using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    bool isGarasi;
    public GameObject garasi, dapur, toilet, lantai1, lantai2;
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    //SPAWN DI GARASI
    public void spawnGarasi(bool parameter)
    {
        float randTime = Random.Range(13, 20);
        if (parameter && enemies.Length <= 0)
        {    
        GameObject enemy = ObjectPool.SharedInstance.GetPooledObject();
            if (enemy != null)
            {
                new WaitForSeconds(randTime);
                enemy.transform.position = garasi.transform.position;
                enemy.transform.rotation = garasi.transform.rotation;
                new WaitForSeconds(randTime);
                enemy.SetActive(true);
            }

        }
    }

    //SPAWN DI DAPUR
    public void spawnDapur(bool parameter)
    {
        float randTime = Random.Range(3f, 15f);
        print("dapur");
        if (parameter && enemies.Length <= 0)
        {
            GameObject enemy = ObjectPool.SharedInstance.GetPooledObject();
            if (enemy != null)
            {
                new WaitForSeconds(randTime);
                enemy.transform.position = dapur.transform.position;
                enemy.transform.rotation = dapur.transform.rotation;
                enemy.SetActive(true);
            }

        }
    }

    //SPAWN DI toilet
    public void spawnToilet(bool parameter)
    {
        print("toilet");
        if (parameter && enemies.Length <= 0)
        {
            GameObject enemy = ObjectPool.SharedInstance.GetPooledObject();
            if (enemy != null)
            {
                enemy.transform.position = toilet.transform.position;
                enemy.transform.rotation = toilet.transform.rotation;
                enemy.SetActive(true);
            }

        }
    }

    //spawn lorong lantai 1
    public void spawnLantai1(bool parameter)
    {
        print("lantai1");
        if (parameter && enemies.Length <= 0)
        {
            GameObject enemy = ObjectPool.SharedInstance.GetPooledObject();
            if (enemy != null)
            {
                enemy.transform.position = lantai1.transform.position;
                enemy.transform.rotation = lantai1.transform.rotation;
                enemy.SetActive(true);
            }

        }
    }
    public void spawnLantai2(bool parameter)
    {
        print("lantai2");
        if (parameter && enemies.Length <= 0)
        {
            GameObject enemy = ObjectPool.SharedInstance.GetPooledObject();
            if (enemy != null)
            {
                enemy.transform.position = lantai2.transform.position;
                enemy.transform.rotation = lantai2.transform.rotation;
                enemy.SetActive(true);
            }

        }
    }

}
