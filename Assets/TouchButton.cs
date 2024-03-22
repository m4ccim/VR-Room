using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TouchButton : XRBaseInteractable
{
    [SerializeField] private ushort buttonNumber;
    [SerializeField] private NumberPad linkedKeypad;
    private Renderer m_RendererToChange;
    [SerializeField] private Material normalMaterial;
    [SerializeField] private Material touchedMaterial;

    protected override void Awake()
    {
        base.Awake();
        m_RendererToChange = GetComponent<Renderer>();
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        m_RendererToChange.material = touchedMaterial;
        linkedKeypad.ButtonPressed(buttonNumber);
    }
    
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        m_RendererToChange.material = normalMaterial;
    }
}
