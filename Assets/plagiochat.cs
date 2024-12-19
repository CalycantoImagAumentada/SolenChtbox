using UnityEngine;
using UnityEngine.UI;

public class ChatControllerExample : MonoBehaviour
{
    public InputField inputField;
    public Text chatDisplay;
    public string userName = "Usuario";

    public void SendMessage()
    {
        if (inputField != null && chatDisplay != null)
        {
            string message = inputField.text;

            if (!string.IsNullOrEmpty(message))
            {
                chatDisplay.text += "<b>" + userName + ":</b> " + message + "\n";
                inputField.text = ""; // Borrar el campo de entrada después de enviar el mensaje
            }
        }
        else
        {
            Debug.LogWarning("inputField o chatDisplay no están asignados en el Inspector de Unity.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && inputField.isFocused)
        {
            SendMessage();
        }
    }
}








 