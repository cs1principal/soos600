using UnityEngine;
using UnityEngine.UI;

public class ContainerTextScript : MonoBehaviour
{
    private RectTransform rectTransform;

    public Text text;

    public float Margin;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        rectTransform.sizeDelta = new Vector2(text.preferredWidth + Margin + Margin, rectTransform.sizeDelta.y);
    }

    private void Update()
    {
        rectTransform.sizeDelta = new Vector2(text.preferredWidth + Margin + Margin, rectTransform.sizeDelta.y);
    }
}