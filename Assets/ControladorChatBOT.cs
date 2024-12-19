using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeEscena : MonoBehaviour
{
    public void IrAChatbot()
    {
        SceneManager.LoadScene("Chatbot");
    }
}
