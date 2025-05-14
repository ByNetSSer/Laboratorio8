using UnityEngine;
using TMPro;
using System;
public class CoinPanel : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI Coins;
    private void Awake()
    {
        Coins = GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        GameManager.OnCoinUpdate += OncoinUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnCoinUpdate -= OncoinUpdate;
    }
    private void OncoinUpdate(int coins)
    {
        Coins.text = ""+coins;
    }
}
