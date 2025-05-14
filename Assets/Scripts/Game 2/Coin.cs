using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Vector3 AngleRotatios;
    private void Update()
    {
        QuaternionRotatiom();
    }
    private void QuaternionRotatiom()
    {
        Quaternion rotation = Quaternion.Euler(AngleRotatios);
        transform.rotation = transform.rotation* rotation;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.Instance.GainCoin();
        }
    }
}
