using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

public class Dialogo : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI chatDisplay;
    public string userName = "Usuario";

    void Start()
    {
        if (inputField == null || chatDisplay == null)
        {
            Debug.LogWarning("inputField o chatDisplay no están asignados en el Inspector de Unity.");
        }
    }

    public void SendMessage()
    {
        if (inputField != null && chatDisplay != null)
        {
            string message = inputField.text;

            if (!string.IsNullOrEmpty(message))
            {
                chatDisplay.text += "<b>" + userName + ":</b> " + message + "\n";
                inputField.text = "";

                StartCoroutine(EnviarSolicitud(message));
            }
        }
        else
        {
            Debug.LogWarning("inputField o chatDisplay no están asignados en el Inspector de Unity.");
        }
    }

    IEnumerator EnviarSolicitud(string mensaje)
    {
        string url = "http://localhost:5005/webhooks/rest/webhook";

        var data = new
        {
            sender = userName,
            message = mensaje
        };

        string jsonData = JsonConvert.SerializeObject(data);

        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();

        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error al enviar el mensaje: " + request.error);
            chatDisplay.text += "<b>Error:</b> " + request.error + "\n";
        }
        else
        {
            string responseFromServer = request.downloadHandler.text;
            Debug.Log("Respuesta: " + responseFromServer);

            var messages = JsonConvert.DeserializeObject<List<ResponseMessage>>(responseFromServer);
            foreach (var msg in messages)
            {
                if (!string.IsNullOrEmpty(msg.text))
                {
                    chatDisplay.text += "<b>Server:</b> " + msg.text + "\n";
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && inputField.isFocused)
        {
            SendMessage();
        }
    }

    [System.Serializable]
    public class ResponseMessage
    {
        public string recipient_id;
        public string text;
    }
}
