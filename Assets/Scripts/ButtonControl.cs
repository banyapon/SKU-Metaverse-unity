using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.Layouts;

public class ButtonControl : OnScreenControl, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerUp(PointerEventData eventData)
    {
        SendValueToControl(0.0f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SendValueToControl(1.0f);
    }

    [InputControl(layout = "Button")]
    [SerializeField]
    private string m_ControlPath;

    protected override string controlPathInternal
    {
        get => m_ControlPath;
        set => m_ControlPath = value;
    }
}
