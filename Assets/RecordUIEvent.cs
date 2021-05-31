using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RecordUIEvent : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(transform.GetPath() + "OnPointerClick, eventData:" + eventData);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(transform.GetPath() + "OnPointerClick, eventData:" + eventData);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(transform.GetPath() + "OnPointerClick, eventData:" + eventData);
    }
}
