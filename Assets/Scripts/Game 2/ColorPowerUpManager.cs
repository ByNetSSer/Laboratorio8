using UnityEngine;
using System;
using UnityEngine.InputSystem;
public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] colors;
    [SerializeField] private ColorData Concurrentcolor;
    [SerializeField] private int ConcurrentState = 0;
    [SerializeField] private bool CanChangeColor = true;
    public  static event Action<ColorData> OnchangeColor;
    private void Start()
    {
        Concurrentcolor = colors[0];
       //OnchangeColor.Invoke(Concurrentcolor);
    }
    public void OnpreviousColor(InputAction.CallbackContext context)
    {
        
        if (!context.performed) return;
        if (ConcurrentState-1 >=0 && CanChangeColor)
        {
            ConcurrentState--;
            ChangeColorSelection();
        }
    }
    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (!context.performed) return; 
        if (ConcurrentState + 1 < colors.Length && CanChangeColor)
        {
            ConcurrentState++;
            ChangeColorSelection();

        }
    }
    private void ChangeColorSelection()
    {
        Concurrentcolor = colors[ConcurrentState];
        OnchangeColor.Invoke(Concurrentcolor);
    }
    private void ValidateCollision(ColorData otherColor, int Damage)
    {
        if (Concurrentcolor != otherColor)
        {
            GameManager.Instance.ModifyLife(Damage);
        }
        CanChangeColor = false;
    }
    private void ReturToNormal()
    {
        CanChangeColor = true;
    }
    private void OnEnable()
    {
        Enemy.OnEnter += ValidateCollision;
        Enemy.OnExit += ReturToNormal;
    }
    private void OnDisable()
    {
        Enemy.OnEnter -= ValidateCollision;
        Enemy.OnExit -= ReturToNormal;
    }
}
