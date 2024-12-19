using UnityEngine;

public class ZoomController : MonoBehaviour
{
    public Transform mapTransform; // Referencia al transform de la imagen del mapa
    public float zoomSpeed = 2f;
    public float minZoom = -3f; // Valor inicial para minZoom
    public float maxZoom = 0.25f; // Valor para maxZoom

    public void ZoomIn()
    {
        float newScale = mapTransform.localScale.x + zoomSpeed;
        mapTransform.localScale = new Vector3(Mathf.Clamp(newScale, minZoom, maxZoom), Mathf.Clamp(newScale, minZoom, maxZoom), 1f);
    }

    public void ZoomOut()
    {
        float newScale = mapTransform.localScale.x / (1 + zoomSpeed); // Dividir por un valor mayor a 1 para alejar gradualmente
        mapTransform.localScale = new Vector3(Mathf.Clamp(newScale, minZoom, maxZoom), Mathf.Clamp(newScale, minZoom, maxZoom), 1f);
    }
}

