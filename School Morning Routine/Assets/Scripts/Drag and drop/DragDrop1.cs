using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop1 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
    private RectTransform recTransform;
    private CanvasGroup canvasGroup;
    public AudioSource audioData;
    
    private void Awake()
    {
        recTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        audioData.Play(0);
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }
        public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        recTransform.anchoredPosition += eventData.delta;
    }
        public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
