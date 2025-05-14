using UnityEngine;
using System;
public class Enemy : MonoBehaviour
{
    [SerializeField] private ColorData enemyColor;
    [SerializeField] private int Damage;
    public static event Action<ColorData, int> OnEnter;
    public static event Action OnExit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OnEnter.Invoke(enemyColor,Damage);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OnExit.Invoke();
        }
    }
}
