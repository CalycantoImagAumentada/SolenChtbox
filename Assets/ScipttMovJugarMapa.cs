using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public float dragSpeed = 30f; // Velocidad de arrastre
    public float minX = -1060f; // Valor mínimo de la posición X
    public float maxX = 2500f; // Valor máximo de la posición X
    public float minY = 1100f; // Valor mínimo de la posición Y
    public float maxY = 2000f; // Valor máximo de la posición Y

    private Vector3 dragOrigin; // Origen del arrastre

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        // Aplicar restricciones de movimiento
        Vector3 newPos = transform.position - move;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);

        // Aplicar el movimiento a la posición del objeto del mapa
        transform.position = newPos;
    }
}
