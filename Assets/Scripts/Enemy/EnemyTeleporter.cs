using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleporter : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator setActive()
    {
        yield return new WaitForSeconds(2);
        go.SetActive(true);
        yield return new WaitForSeconds(6);
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    public void waitActive(bool active)
    {
        if(active)
        {
            StartCoroutine(setActive());
            gameObject.GetComponent<BoxCollider>().enabled = false;
            active = false;

        }
    }
}
