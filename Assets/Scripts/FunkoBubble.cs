using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunkoBubble : MonoBehaviour
{
    private SpriteRenderer bubbleBackground;
    public TextMeshPro textMeshPro;
    public GameObject bubbleChat;
    string text = "Ada Batu";
    string text2 = "Batunya Diatas";
    bool adaga = true;
    private void Start()
    {
        
    }
    //private void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if (collider.CompareTag("Player"))
    //    {
    //        textMeshPro.SetText(text);
    //        bubbleChat.gameObject.SetActive(true);
    //        StartCoroutine(BubbleGone());
    //    } 
    //}

    //public IEnumerator BubbleGone()
    //{
    //    yield return new WaitForSeconds(2f);
    //    bubbleChat.gameObject.SetActive(false);
    //    yield return new WaitForSeconds(30f);
    //    textMeshPro.SetText(text2);
    //    bubbleChat.gameObject.SetActive(true);
    //    yield return new WaitForSeconds(2f);
    //    bubbleChat.gameObject.SetActive(false);
    //}
}
