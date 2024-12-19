using UnityEngine;
using UnityEngine.UI;

public class Controllerchat : MonoBehaviour
{
    public InputField messageInputField; // Referencia al campo de entrada de texto
    public Text chatText; // Referencia al área de texto donde se muestra el chat

    public void SendMessage()
    {
        // Verifica si el campo de entrada de mensaje no está vacío
        if (!string.IsNullOrEmpty(messageInputField.text))
        {
            string message = messageInputField.text; // Obtiene el mensaje del campo de entrada
            AddMessageToChat(message); // Agrega el mensaje al área de texto del chat
            ClearMessageInputField(); // Limpia el campo de entrada después de enviar el mensaje
        }
    }

    private void AddMessageToChat(string message)
    {
        // Agrega el mensaje al área de texto del chat
        chatText.text += "\n" + message;
    }

    private void ClearMessageInputField()
    {
        // Limpia el campo de entrada después de enviar el mensaje
        messageInputField.text = "";
    }
}
