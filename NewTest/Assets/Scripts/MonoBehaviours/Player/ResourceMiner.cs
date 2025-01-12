using UnityEngine;
using Zenject;
public class ResourceMiner : MonoBehaviour
{
    private ObjectSelector _objectSelector;
    [Inject] private IInputHandler _inputHandler;

    public void Init(ObjectSelector objectSelector)
    {
        _objectSelector = objectSelector;
    }

    public void TryMine()
    {
        if (_objectSelector.SelectedObject is Resource)
        {
            var resource = _objectSelector.SelectedObject as Resource;
            resource.Mine();
        }
    }

    private void Update()
    {
        if (_inputHandler.GetUseButtonDown())
        {
            TryMine();
        }
    }
}