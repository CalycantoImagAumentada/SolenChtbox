using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBotonAtrasCruz : MonoBehaviour
{
    public void IrAJugarMapa()
    {
        SceneManager.LoadScene("jugarmapa");
    }
}
