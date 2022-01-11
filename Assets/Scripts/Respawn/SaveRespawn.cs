using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveRespawn : MonoBehaviour
{
    Transform tempPoint, spawnPoint;
    public GameObject GameOverUI;
    AudioSource _enemysound;
    GameObject enemyprefs;
    // Start is called before the first frame update
    void Start()
    {
        tempPoint = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _enemysound = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AudioSource>();
        //print(tempPoint.position);
        enemyprefs = GameObject.FindGameObjectWithTag("Enemy");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("SoulStone"))
        {
            GetLocationDead(tempPoint);
        }

    }

    private void GetLocationDead(Transform parameter)
    {
        spawnPoint = parameter;
        print(spawnPoint.position);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
            _enemysound.Stop();
            enemyprefs.SetActive(false);

        }
    }

    public void respawnImpi()
    {
        transform.position = spawnPoint.position;
        GameOverUI.SetActive(false);
        Time.timeScale = 1;

    }
}