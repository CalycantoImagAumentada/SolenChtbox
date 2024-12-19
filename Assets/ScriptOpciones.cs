using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAOpcionesSolen : MonoBehaviour
{
    public void CargarEscenaOpcionesSolen()
    {
        SceneManager.LoadScene("CrearCuenta");
    }
}

public class IniciarSesion : MonoBehaviour
{
    public void CargarEscenaDeInicio()
    {
        SceneManager.LoadScene("opcionesSolen");
    }
}


