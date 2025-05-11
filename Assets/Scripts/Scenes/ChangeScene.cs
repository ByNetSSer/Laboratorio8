using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string Escena;

    public void ChancgeScene()
    {
        if (Escena == null) return;
        SceneManager.LoadScene(Escena);
    }
}
