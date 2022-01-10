using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLukisan : MonoBehaviour
{
    public GameObject lukisan;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKey(KeyCode.G))
            {
                lukisan.SetActive(true);
            }
        }
    }
}
