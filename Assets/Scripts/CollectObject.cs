using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectObject : MonoBehaviour
{
    public int soulstone = 0;
    public GameObject canvasEnding;
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
    public void getSoulStone(int param)
    {
        soulstone = soulstone + param;
        soulstoneText.text = "" + soulstone;
    }

    private void Update()
    {
        if(soulstone >=5)
        {
            canvasEnding.SetActive(true);
            StartCoroutine(waitQuit());
        }
    }

    IEnumerator waitQuit()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Main Menu");
    }
}
