using UnityEngine;

public class ZoomController : MonoBehaviour
{
    public Transform mapTransform; // Transform de la imagen del mapa
    public float zoomSpeed = 3f; // Velocidad de zoom
    public float maxZoom = 3f; // Escala máxima para acercar
    private Vector3 initialScale; // Escala inicial del mapa (zoom común de inicio)

    private void Start()
    {
        // Guardar la escala inicial del mapa
        initialScale = mapTransform.localScale;
    }

    public void ZoomIn()
    {
        // Incrementa la escala, pero limita al máximo definido
        float newScale = mapTransform.localScale.x + (zoomSpeed * 0.1f); // Ajustar 0.1f para más suavidad
        newScale = Mathf.Clamp(newScale, initialScale.x, maxZoom); // Entre escala inicial y el zoom máximo
        mapTransform.localScale = new Vector3(newScale, newScale, 1f);
    }

    public void ZoomOut()
    {
        // Regresa gradualmente al zoom inicial, pero no aleja más allá de este punto
        float newScale = mapTransform.localScale.x - (zoomSpeed * 0.1f); 
        newScale = Mathf.Clamp(newScale, initialScale.x, maxZoom); // Límite: no menos que la escala inicial
        mapTransform.localScale = new Vector3(newScale, newScale, 1f);
    }
}
