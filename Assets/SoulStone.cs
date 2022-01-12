using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulStone : MonoBehaviour
{
    public int idsoul;
    StorySoulStoneSprite ss;
    // Start is called before the first frame update
    void Start()
    {
        ss = GameObject.FindGameObjectWithTag("StorySoul").GetComponent<StorySoulStoneSprite>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            ss.getParameterId(idsoul);
        }
    }
}
