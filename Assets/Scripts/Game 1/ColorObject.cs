using UnityEngine;
using System;
public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData colorData;
    [SerializeField] SpriteRenderer spriteRenderer;
    public static event Action<Color> OnChangeColor;
    private void Awake()
    {
        SetUp();
    }
    private void SetUp()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colorData.color;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && colorData != null)
        {
            OnChangeColor.Invoke(colorData.color);
        }
    }
}
