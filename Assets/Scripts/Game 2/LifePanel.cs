using UnityEngine;
using TMPro;
public class LifePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Life;
    private void Awake()
    {
        Life=GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        GameManager.OnLifeUpdate += OnLifeUpdate;

    }
    private void OnDisable()
    {
        GameManager.OnLifeUpdate -= OnLifeUpdate;
    }
    private void OnLifeUpdate(int life)
    {
        Life.text = "" + life;
        Debug.Log("Cambie");
    }
}
