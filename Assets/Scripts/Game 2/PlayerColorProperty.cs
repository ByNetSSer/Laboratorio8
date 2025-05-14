using UnityEngine;

public class PlayerColorProperty : ColorPropety
{
    private void OnEnable()
    {
        ColorPowerUpManager.OnchangeColor += SetUpColor;
    }
    private void OnDisable()
    {
        ColorPowerUpManager.OnchangeColor -= SetUpColor;
    }
}
