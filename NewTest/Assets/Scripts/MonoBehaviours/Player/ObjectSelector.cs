using UnityEngine;
using Zenject;
public class ObjectSelector : MonoBehaviour 
{
    [Inject] IInputHandler _inputHandler;
    public ICanBeSelected SelectedObject { get; private set; }

    public void TrySelect(Vector3 position)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            var selectedObject = hit.transform.GetComponent<ICanBeSelected>();
            if (selectedObject != null)
            {
                SelectedObject = selectedObject;
                Debug.Log($"Selected: {hit.transform.name}");
            }
            else SelectedObject = null;
        }
    }

    private void OnEnable()
    {
        _inputHandler.OnSelectButtonDown += TrySelect;
    }

    private void OnDisable()
    {
        _inputHandler.OnSelectButtonDown -= TrySelect;
    }
}