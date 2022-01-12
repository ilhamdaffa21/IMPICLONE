using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGarasi : MonoBehaviour
{
    GameObject gm;
    EnemySpawn es;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
       es = (EnemySpawn)gm.GetComponent(typeof(EnemySpawn));
        enemy = GameObject.FindGameObjectWithTag("Enemy");

    }

    // Update is called once per frame  
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(waitTime());
            //  enemy.SetActive(false);

        }

    }

    IEnumerator waitTime()
    {
        float randTime = Random.Range(1, 8);
        yield return new WaitForSeconds(randTime);
        es.spawnGarasi(true);
    }
}
