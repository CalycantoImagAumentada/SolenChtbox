using UnityEngine;
using UnityEngine.Networking;
using System.Collections; // Agrega esta línea

public class APIClient : MonoBehaviour
{
    void Start()
    {
        // Inicia la corutina para hacer la solicitud
        StartCoroutine(GetRequest("http://0.0.0.0:5005/webhooks/rest/webhook"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Envía la solicitud y espera hasta que se complete
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log("Error: " + webRequest.error);
            }
            else
            {
                // Muestra el resultado como texto
                Debug.Log("Received: " + webRequest.downloadHandler.text);
            }
        }
    }
}
