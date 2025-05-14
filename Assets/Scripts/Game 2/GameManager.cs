using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int Playerlife;
    [SerializeField] private int PlayerCoins;
    public static event Action<int> OnLifeUpdate;
    public static event Action<int> OnCoinUpdate;
    public static event Action OnWin;
    public static event Action OnLosse;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    public void GainCoin()
    {
        PlayerCoins++;
        OnCoinUpdate.Invoke(PlayerCoins);
    }
    public void ModifyLife(int modify)
    {
        Playerlife += modify;
        OnLifeUpdate.Invoke(Playerlife);
    }
    public void CheckWin()
    {
        Debug.Log("Ganaste");
    }
    private void ValidateLife()
    {
        if (Playerlife <= 0)
        {
            Debug.Log("perdiste");
            OnLosse.Invoke();
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lose")
        {
            OnLosse.Invoke();

        }
        if (other.gameObject.tag =="Win")
        {
            OnWin.Invoke();
        }
    }
    private void OnEnable()
    {
        OnWin += CheckWin;
    }
    private void OnDisable()
    {
        OnWin -= CheckWin;
    }
}
