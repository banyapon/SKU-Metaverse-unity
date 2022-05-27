using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.Layouts;

public class StickControl : OnScreenControl, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public RectTransform background;
    public RectTransform stick;

    public void OnDrag(PointerEventData eventData)
    {
        stick.position = eventData.position;
        stick.localPosition = Vector2.ClampMagnitude(eventData.position - (Vector2)background.position, background.rect.width * 0.5f);
        Vector2 newPos = stick.localPosition;
        SendValueToControl(newPos);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        stick.localPosition = Vector2.zero;
        background.gameObject.SetActive(false);
        SendValueToControl(Vector2.zero);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        background.position = eventData.position;
        background.gameObject.SetActive(true);
    }

    [InputControl(layout = "Vector2")]
    [SerializeField] private string m_ControlPath;

    protected override string controlPathInternal
    {
        get => m_ControlPath;
        set => m_ControlPath = value;
    }
}