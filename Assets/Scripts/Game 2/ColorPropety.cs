using UnityEngine;

public class ColorPropety : MonoBehaviour
{
    [SerializeField] protected ColorData colorData;
    [SerializeField] protected MeshRenderer meshRenderer;
    protected Material _material;
    
    private void Awake()
    {
       meshRenderer = GetComponent<MeshRenderer>();
        
    }
    protected void Start()
    {
        _material = meshRenderer.material;

        SetUpColor(colorData);
    }
    protected void SetUpColor(ColorData newColorData)
    {
        colorData = newColorData;

        _material.SetColor("_Color", colorData.color);
    }
}
