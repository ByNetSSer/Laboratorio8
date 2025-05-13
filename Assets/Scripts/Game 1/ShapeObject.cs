using UnityEngine;
using System;
public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapedata;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public static event Action<Sprite> OnChangeShape;
    private void Awake()
    {
        SetUp();
    }
    private void SetUp()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = shapedata.sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && shapedata != null)
        {
            OnChangeShape.Invoke(spriteRenderer.sprite);
        }
    }
}
