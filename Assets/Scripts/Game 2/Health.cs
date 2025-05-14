using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int LifeRecover;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.Instance.ModifyLife( LifeRecover);
        }
    }
}
