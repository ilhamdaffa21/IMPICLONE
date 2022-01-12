using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveRespawn : MonoBehaviour
{
    Transform tempPoint, spawnPoint;
    AudioSource _enemysound;
    GameObject enemyprefs;
    public GameObject impi, GameOverUI;
    RespawnImpi ri;
    Movement mv;
    // Start is called before the first frame update
    void Start()
    {
        mv = GetComponent<Movement>();
        tempPoint = GetComponent<Transform>();
        ri = GameObject.FindGameObjectWithTag("Player").GetComponent<RespawnImpi>();
    }

    // Update is called once per frame
    void Update()
    {
        _enemysound = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AudioSource>();
        //print(tempPoint.position);
        enemyprefs = GameObject.FindGameObjectWithTag("Enemy");
        print(spawnPoint);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("SoulStone"))
        {
            GetLocationDead(tempPoint);
            print("get");
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
            mv.getParameterPause(true);
            Time.timeScale = 0;
            _enemysound.Stop();
            enemyprefs.SetActive(false);
            GameOverUI.SetActive(true);


        }
    }
    public void clickRespawn()
    {
        mv.getParameterPause(false);
        ri.respawnImpi(spawnPoint);
    }


}
