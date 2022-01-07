using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    bool isGarasi;
    public GameObject garasi, dapur, toilet;
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
        
        if (parameter && enemies.Length <= 0)
        {    
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = garasi.transform.position;
                //bullet.transform.rotation = garasi.transform.rotation;
                bullet.SetActive(true);
            }

        }
    }

    //SPAWN DI DAPUR
    public void spawnDapur(bool parameter)
    {
        print("dapur");
        if (parameter && enemies.Length <= 0)
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = dapur.transform.position;
                bullet.transform.rotation = dapur.transform.rotation;
                bullet.SetActive(true);
            }

        }
    }

    //SPAWN DI toilet
    public void spawnToilet(bool parameter)
    {
        print("toilet");
        if (parameter && enemies.Length <= 0)
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = toilet.transform.position;
                bullet.transform.rotation = toilet.transform.rotation;
                bullet.SetActive(true);
            }

        }
    }

}
