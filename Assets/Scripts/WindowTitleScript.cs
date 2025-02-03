using UnityEngine;
using UnityEngine.EventSystems;

public class WindowTitleScript : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public WindowScript windowScript;

    private Vector2 offset;

    public void OnDrag(PointerEventData eventData)
    {
        if (!windowScript.IsMaximize)
        {
            RectTransform rectTransform = windowScript.gameObject.GetComponent<RectTransform>();

            rectTransform.position = eventData.position + offset;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!windowScript.IsMaximize)
        {
            RectTransform rectTransform = windowScript.gameObject.GetComponent<RectTransform>();

            offset = new Vector2(rectTransform.position.x, rectTransform.position.y) - eventData.position;
        }
    }
}