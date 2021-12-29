using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    EnemyTeleporter et;
    public Transform pos1, pos2, startPos;
    public float speed, speedWalk;
    bool rush;
    Vector3 nextPos;
    float timerRush = 10f;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        et = GameObject.FindObjectOfType<EnemyTeleporter>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timerRush -= Time.fixedDeltaTime;
        if (timerRush <= 0)
        {
            timerRush = 10f;
            rush = true;
        }

        StartCoroutine(waitFunction());
        Physics2D.IgnoreLayerCollision(8, 9);

    }

    void walk()
    {
        Vector3 charecterScale = transform.localScale;
        if (transform.position == pos1.position)
        {
            charecterScale.x = 1;
            nextPos = pos2.position;
            rush = false;

        }
        if (transform.position == pos2.position)
        {
            charecterScale.x = -1;
            nextPos = pos1.position;
            rush = false;
        }
        transform.localScale = charecterScale;
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speedWalk * Time.deltaTime);
    }

    void enemyRush()
    {
        if (rush)
        {
            Vector3 charecterScale = transform.localScale;
            if (transform.position == pos1.position)
            {
                charecterScale.x = 1;
                nextPos = pos2.position;
                rush = false;

            }
            if (transform.position == pos2.position)
            {
                charecterScale.x = -1;
                nextPos = pos1.position;
                rush = false;
            }
            transform.localScale = charecterScale;
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
    }

    IEnumerator waitFunction()
    {
        yield return new WaitForSeconds(2);
        walk();
        enemyRush();
    }



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("TeleporterEnemy")) ;
    //    {
    //        gameObject.SetActive(false);
    //        et.waitActive(true);
    //    }
    //}
    


}
