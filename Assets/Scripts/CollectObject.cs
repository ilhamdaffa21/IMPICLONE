using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    public int soulstone = 0;

    [SerializeField] private Text soulstoneText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SoulStone"))
        {
            Destroy(collision.gameObject);
            soulstone++;
            soulstoneText.text = "" + soulstone;
        }
    }
}
