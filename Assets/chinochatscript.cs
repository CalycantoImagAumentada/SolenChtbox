//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;
//using UnityEngine.UI;

//public class Dialogo : MonoBehaviour
//{
    //public TextMeshProUGUI textD;
    //public InputField inputField; // Referencia al campo de entrada de texto
    //public Button enviarBoton; // Referencia al botón de enviar
    //public GameObject panelDialogo;

    //private void Start()
    //{
       // panelDialogo.SetActive(false);
        //inputField.gameObject.SetActive(false);
       // enviarBoton.gameObject.SetActive(false);

        // Agregar un listener al botón de enviar
        //enviarBoton.onClick.AddListener(EnviarMensaje);
    //}

    //public void activarBotonLeer()
    //{
        //panelDialogo.SetActive(true);
        //inputField.gameObject.SetActive(true); // Mostrar el campo de entrada
        //enviarBoton.gameObject.SetActive(true); // Mostrar el botón de enviar
   // }

    //void EnviarMensaje()
    //{
        //string mensaje = inputField.text; // Obtener el texto del campo de entrada
        //inputField.text = ""; // Limpiar el campo de entrada
        //MostrarMensaje(mensaje); // Llamar a la función para mostrar el mensaje
    //}

    //void MostrarMensaje(string mensaje)
    //{
        //textD.text += "\n" + mensaje; // Agregar el mensaje al texto existente con un salto de línea
    //}

    //public void botonCerrar()
    //{
       // panelDialogo.SetActive(false);
       // inputField.gameObject.SetActive(false); // Ocultar el campo de entrada
       // enviarBoton.gameObject.SetActive(false); // Ocultar el botón de enviar
    //}
//}