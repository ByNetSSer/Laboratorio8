using UnityEngine;
using UnityEngine.UI;
public class ShapePanel : MonoBehaviour
{
    [SerializeField] private Image ShapeImage;
    private void Awake()
    {
        ShapeImage = GetComponent<Image>();
    }
    private void UpdateShape( Sprite newSprite)
    {
        ShapeImage.sprite = newSprite;
    }
    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}
