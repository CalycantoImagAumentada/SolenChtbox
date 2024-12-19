using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeBotones : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a la que quieres ir

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

   /* public void CargarEscenaDeOpcionesSolen()
    {
        SceneManager.LoadScene("opcionessolen");
    }

    public void CargarEscenaDeInicioSesion()
    {
        SceneManager.LoadScene("iniciarsesion");
    }

    public void CargarEscenaDeCrearCuenta()
    {
        SceneManager.LoadScene("CrearCuenta");
    }*/

   








}
