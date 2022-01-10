using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public int id;
    LukisanManager lm;
    void Start()
    {
        lm = GameObject.Find("LukisanManager").GetComponent<LukisanManager>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                lm.GetParameter(id);
            }
            else
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
            }
        }
    }
}
