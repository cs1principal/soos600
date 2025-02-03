using UnityEngine;
using UnityEngine.EventSystems;

public class WindowBorderScript : MonoBehaviour, IDragHandler
{
    public WindowScript window;
    public int side;

    public void OnDrag(PointerEventData eventData)
    {
        if (!window.IsMaximize)
        {
            RectTransform rectTransform = window.GetComponent<RectTransform>();

            Vector2 mouseDelta = eventData.delta;
            Vector2 sizeDelta = rectTransform.sizeDelta;

            if (side == 0) // Lado izquierdo
            {
                rectTransform.offsetMin += new Vector2(mouseDelta.x, 0);
                sizeDelta.x -= mouseDelta.x;
            }
            else if (side == 1) // Lado derecho
            {
                sizeDelta.x += mouseDelta.x;
            }
            else if (side == 2) // Lado superior
            {
                sizeDelta.y += mouseDelta.y;
            }
            else if (side == 3) // Lado inferior
            {
                rectTransform.offsetMin += new Vector2(0, mouseDelta.y);
                sizeDelta.y -= mouseDelta.y;
            }

            // Aplicar restricciones de tamaño mínimo y máximo
            sizeDelta.x = Mathf.Clamp(sizeDelta.x, -window.maxWidth, -window.minWidth);
            sizeDelta.y = Mathf.Clamp(sizeDelta.y, -window.maxHeight, -window.minHeight);

            rectTransform.sizeDelta = sizeDelta;

            // Experimento
            /*bool isCorrect = true;

            if (side == 0) // Lado izquierdo
            {
                //rectTransform.offsetMin += new Vector2(mouseDelta.x, 0);
                float size = sizeDelta.x - mouseDelta.x;

                isCorrect = (size >= -window.maxWidth) && (size < -window.minWidth);
            }
            else if (side == 1) // Lado derecho
            {
                float size = sizeDelta.x + mouseDelta.x;

                isCorrect = (size >= -window.maxWidth) && (size < -window.minWidth);
            }
            else if (side == 2) // Lado superior
            {
                float size = sizeDelta.y + mouseDelta.y;

                isCorrect = (size >= -window.maxWidth) && (size < -window.minWidth);
            }
            else if (side == 3) // Lado inferior
            {
                //rectTransform.offsetMin += new Vector2(0, mouseDelta.y);
                float size = sizeDelta.y - mouseDelta.y;

                isCorrect = (size >= -window.maxWidth) && (size < -window.minWidth);
            }


            if (isCorrect)
            {
                if (side == 0) // Lado izquierdo
                {
                    rectTransform.offsetMin += new Vector2(mouseDelta.x, 0);
                    sizeDelta.x -= mouseDelta.x;
                }
                else if (side == 1) // Lado derecho
                {
                    sizeDelta.x += mouseDelta.x;
                }
                else if (side == 2) // Lado superior
                {
                    sizeDelta.y += mouseDelta.y;
                }
                else if (side == 3) // Lado inferior
                {
                    rectTransform.offsetMin += new Vector2(0, mouseDelta.y);
                    sizeDelta.y -= mouseDelta.y;
                }

                // Aplicar restricciones de tamaño mínimo y máximo
                sizeDelta.x = Mathf.Clamp(sizeDelta.x, -window.maxWidth, -window.minWidth);
                sizeDelta.y = Mathf.Clamp(sizeDelta.y, -window.maxHeight, -window.minHeight);

                rectTransform.sizeDelta = sizeDelta;
            }*/
        }
    }
}

/*using UnityEngine;
using UnityEngine.EventSystems;

public class WindowBorderScript : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public WindowScript window;

    public int side;

    public void OnDrag(PointerEventData eventData)
    {
        if (!window.IsMaximize)
        {
            RectTransform rectTransform = window.GetComponent<RectTransform>();

            Vector2 mouseDelta = eventData.delta;
            Vector2 sizeDelta = rectTransform.sizeDelta;

            if (side == 0)
            {
                rectTransform.offsetMin += new Vector2(mouseDelta.x, 0);
                sizeDelta.x -= mouseDelta.x;
            }
            else if (side == 1)
            {
                sizeDelta.x += mouseDelta.x;
            }
            else if (side == 2)
            {
                sizeDelta.y += mouseDelta.y;
            }
            else if (side == 3)
            {
                rectTransform.offsetMin += new Vector2(0, mouseDelta.y);
                sizeDelta.y -= mouseDelta.y;
            }

            sizeDelta.x = Mathf.Clamp(sizeDelta.x, window.minWidth, window.maxWidth);
            sizeDelta.y = Mathf.Clamp(sizeDelta.y, window.minHeight, window.maxHeight);

            rectTransform.sizeDelta = sizeDelta;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!window.IsMaximize)
        {
            RectTransform rectTransform = window.gameObject.GetComponent<RectTransform>();

            //offset = eventData.position;
            //size = rectTransform.sizeDelta;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}*/