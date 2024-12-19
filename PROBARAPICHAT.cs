using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI textD;
    public GameObject panelDialogo;
    public TMP_InputField inputField;
    public float duracionMensaje = 5f;
    private Coroutine fadeCoroutine;

    // URL de tu servidor Flask
    public string url = "http://localhost:5000/api";

    // Método que se llama al hacer clic en el botón de enviar
    public void EnviarMensaje()
    {
        // Obtener el mensaje del inputField
        string mensaje = inputField.text;

        // Mostrar el mensaje en el panel de diálogo
        textD.text += "\n" + mensaje; // Agregar el mensaje nuevo al final de los mensajes anteriores
        panelDialogo.SetActive(true);

        // Limpiar el campo de texto después de enviar el mensaje
        inputField.text = "";

        // Enviar el mensaje a la API Python
        StartCoroutine(EnviarSolicitud(mensaje));
    }

    // Coroutine para enviar el mensaje a la API Python
    private IEnumerator EnviarSolicitud(string mensaje)
    {
        // Crear el objeto JSON a enviar
        string json = "{\"mensaje\": \"" + mensaje + "\"}";

        // Configurar la solicitud POST
        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // Enviar la solicitud
        yield return request.SendWebRequest();

        // Procesar la respuesta
        if (request.result == UnityWebRequest.Result.Success)
        {
            string respuesta = request.downloadHandler.text;
            Debug.Log("Respuesta del servidor: " + respuesta);
            // Mostrar la respuesta en el panel de diálogo
            textD.text += "\n" + respuesta;
        }
        else
        {
            Debug.LogError("Error en la solicitud: " + request.error);
        }

        // Iniciar el coroutine para desvanecer el mensaje después de un tiempo
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }
        fadeCoroutine = StartCoroutine(DesvanecerMensaje());
    }

    // Método que se llama al hacer clic en el botón de cerrar el diálogo
    public void CerrarDialogo()
    {
        panelDialogo.SetActive(false);
    }

    // Coroutine para desvanecer el mensaje después de un tiempo
    private IEnumerator DesvanecerMensaje()
    {
        yield return new WaitForSeconds(duracionMensaje);
        textD.text = ""; // Limpiar el texto después de un cierto tiempo
        panelDialogo.SetActive(false); // Ocultar el panel de diálogo
    }
}
