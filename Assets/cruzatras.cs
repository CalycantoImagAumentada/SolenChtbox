using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBotonCruz : MonoBehaviour
{
    public void IrAJugarMapa()
    {
        SceneManager.LoadScene("jugarmapa");
    }
}
