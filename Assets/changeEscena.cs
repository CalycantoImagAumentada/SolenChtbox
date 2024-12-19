using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour
{
    public string opcionessolen;
    public string iniciarsesion;
    public string CrearCuenta;
    public string jugarmapa;
    public string textbot;
    public string camaraop;
    

    public void CargarEscena1()
    {
        SceneManager.LoadScene(opcionessolen);
    }

    public void CargarEscena2()
    {
        SceneManager.LoadScene(iniciarsesion);
    }

    public void CargarEscena3()
    {
        SceneManager.LoadScene(CrearCuenta);
    }

    public void CargarEscena4()
    {
        SceneManager.LoadScene(jugarmapa);
    }

    public void CargarEscena5()
    {
        SceneManager.LoadScene(textbot);
    }

     public void CargarEscena6()
    {
        SceneManager.LoadScene(camaraop);
    }





}

