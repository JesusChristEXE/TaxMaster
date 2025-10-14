using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableObjectScript : MonoBehaviour
{
    private Vector3 mousePositionOffset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        // Calculate the offset between the object's position and the mouse click position
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            // Update the object's position to follow the mouse, maintaining the initial offset
            transform.position = GetMouseWorldPosition() + mousePositionOffset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Get the mouse position in screen coordinates
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Set the Z-coordinate to the object's current Z-coordinate to keep it in the 2D plane
        mouseScreenPosition.z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Convert the screen position to world coordinates
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}
