using UnityEngine;

public class InputHandlerSelector : MonoBehaviour
{
    [SerializeField] private HandlerType _handlerType;
    [SerializeField] private DesktopInputHandler _desktopInputHandler;
    public IInputHandler InputHandler
    {
        get
        {
            switch (_handlerType)
            {
                case HandlerType.Desktop:
                    return _desktopInputHandler;
                default:
                    return _desktopInputHandler;
            }
        }
    }

    private void Awake()
    {
        
    }

    public enum HandlerType
    {
        Desktop
    }
}