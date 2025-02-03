using UnityEngine;
using UnityEngine.UI;

public class WindowScript : MonoBehaviour
{
    public Text title;
    public Button restore;
    public Button maximize;
    public Button close;

    private Vector2? restorePosition;
    private Vector2? restoreSize;

    public float minWidth = 100.0f;
    public float maxWidth = 800.0f;
    public float minHeight = 100.0f;
    public float maxHeight = 800.0f;

    public string Title;

    public bool IsMaximize => restorePosition != null;

    private void Start()
    {
        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);

        restore.onClick.AddListener(Restore);
        maximize.onClick.AddListener(Maximize);
        close.onClick.AddListener(() => Destroy(gameObject));
    }

    private void Update()
    {
        title.text = Title;
    }

    public void Restore()
    {
        transform.position = restorePosition ?? Vector2.zero;
        GetComponent<RectTransform>().sizeDelta = restoreSize ?? Vector2.zero;

        restorePosition = null;
        restoreSize = null;

        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);
    }

    private void Maximize()
    {
        restorePosition = transform.position;
        restoreSize = GetComponent<RectTransform>().sizeDelta;

        transform.position = Vector2.zero;
        GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, maxHeight);

        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);
    }
}

/*using UnityEngine;
using UnityEngine.UI;

public class WindowScript : MonoBehaviour
{
    public Text title;
    public Button restore;
    public Button maximize;
    public Button close;

    private Vector2? RestaurePosition;
    private Vector2? RestauseSize;

    public float minWidth = 100.0f;
    public float maxWidth = 800.0f;
    public float minHeight = 100.0f;
    public float maxHeight = 800.0f;

    public string Title;

    public bool IsMaximize => RestaurePosition != null;

    public void Start()
    {
        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);

        restore.onClick.AddListener(Restore);
        maximize.onClick.AddListener(Maximize);
        close.onClick.AddListener(() => Destroy(gameObject));
    }

    public void Update()
    {
        title.text = Title;
    }

    public void Restore()
    {
        transform.position = RestaurePosition ?? Vector2.zero;
        GetComponent<RectTransform>().sizeDelta = RestauseSize ?? Vector2.zero;

        RestaurePosition = null;
        RestauseSize = null;

        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);
    }

    private void Maximize()
    {
        RestaurePosition = transform.position;
        RestauseSize = GetComponent<RectTransform>().sizeDelta;

        transform.position = Vector2.zero;
        //GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, maxHeight);

        restore.gameObject.SetActive(IsMaximize);
        maximize.gameObject.SetActive(!IsMaximize);
    }
}*/