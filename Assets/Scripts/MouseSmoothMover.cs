using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object to the mouse position,
 * as long as the mouse-button is held.
 */
public class MouseSmoothMover : MonoBehaviour {
    void Update() {
        if (Mouse.current.leftButton.isPressed) {  // left button down
            Vector3 mousePositionInScreenCoordinates = Mouse.current.position.ReadValue();
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
