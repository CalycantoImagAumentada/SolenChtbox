using UnityEngine;
using UnityEngine.UI;

public class areacontroll : MonoBehaviour
{
    public InputField messageInputField; // Referencia al campo de entrada de texto
    public Text chatText; // Referencia al área de texto donde se muestra el chat

    public void SendMessage()
    {
        string message = messageInputField.text; // Obtiene el mensaje del campo de entrada
        chatText.text += "\n" + message; // Agrega el mensaje al área de texto del chat
        messageInputField.text = ""; // Limpia el campo de entrada después de enviar el mensaje
    }
}
