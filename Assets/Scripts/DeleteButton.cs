using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
public class DeleteButton : MonoBehaviour
{
    [SerializeField] private Button _deleteButton;

    private GameObject _currentSelectedGameObject;

    private void Start()
    {
        _deleteButton.onClick.AddListener(ButtonClicked);
    }
    public void SelectEnter(SelectEnterEventArgs args)
    {
        _currentSelectedGameObject = args.interactableObject.transform.gameObject;
        _deleteButton.interactable = true;
    }

    public void SelectExit(SelectExitEventArgs args)
    {
        _deleteButton.interactable = false;
    }

    private void ButtonClicked()
    {
        Destroy(_currentSelectedGameObject);
    }
}
