using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData playerData;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetUp();
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }
    private void SetUp()
    {
        spriteRenderer.color = playerData.color;
        spriteRenderer.sprite = playerData.sprite;
    }
    private void UpdateColor(Color color)
    {
        spriteRenderer.color = color;
        playerData.color = color;
       // SetUp();
    }
    private void UpdateShape(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
        playerData.sprite = sprite;
        //SetUp();
    }
}
