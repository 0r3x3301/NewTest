using UnityEngine;

public class InputHandlersSelector : MonoBehaviour
{
    [SerializeField] private InputHandlers _currentInputHandler;
    [SerializeField] private DesktopInputHandler _desktopInputHandler;

    public IInputHandler GetHandler()
    {
        switch (_currentInputHandler)
        {
            case InputHandlers.Desktop:
                _desktopInputHandler.enabled = true;
                return _desktopInputHandler;
            case InputHandlers.Mobile:
                Debug.LogError("Not implemented handler");
                return null;
        }
        return null;
    }

    private enum InputHandlers
    {
        Desktop,
        Mobile
    }
}
