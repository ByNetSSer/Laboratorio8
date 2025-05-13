using UnityEngine;
using UnityEngine.UI;
public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Image ColorImage;
    private void Awake()
    {
        ColorImage = GetComponent<Image>();
    }
    private void UpdateColor( Color newcolor)
    {
        ColorImage.color = newcolor;
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
    }
}
