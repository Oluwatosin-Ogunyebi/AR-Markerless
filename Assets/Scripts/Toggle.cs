using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Toggle : MonoBehaviour
{
    [SerializeField] private RectTransform _menuTransform;
    [SerializeField] private float _openPosition;
    [SerializeField] private float _closedPosition;

    private bool _isOpen;
    private void Start()
    {
        ToggleMenu();
    }
    public void ToggleMenu()
    {
        _isOpen = !_isOpen;
        Vector2 targetPosition = new Vector2(0, _isOpen ? _openPosition : _closedPosition);
        _menuTransform.DOAnchorPos(targetPosition, 0.5f);
    }
}
