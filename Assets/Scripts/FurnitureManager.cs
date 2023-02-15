using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField] private FurnitureData[] _furnitureData;

    [SerializeField] private Transform _contentTransform;

    [SerializeField] private FurnitureMenuOption _furnitureUIPrefab;

    [SerializeField] private ARPlacementInteractable _placementInteractable;

    private FurnitureMenuOption _currentMenuOption;

    void Start()
    {
        foreach (FurnitureData data in _furnitureData)
        {
            FurnitureMenuOption menuOption = Instantiate(_furnitureUIPrefab, _contentTransform);
            menuOption.nameText.text = data.furnitureName;
            menuOption.iconImage.texture = data.furnitureIcon;

            menuOption.button.onClick.AddListener(() => SelectFurniture(menuOption, data));
        }
    }

    private void SelectFurniture(FurnitureMenuOption newMenuOption, FurnitureData furnitureData)
    {
        if (_currentMenuOption != null)
            _currentMenuOption.backgroundImage.color = newMenuOption.backgroundImage.color;

        _currentMenuOption = newMenuOption;
        _placementInteractable.placementPrefab = furnitureData.furniturePrefab;

        newMenuOption.backgroundImage.color = Color.yellow;
    }
}
