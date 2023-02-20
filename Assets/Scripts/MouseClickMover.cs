using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component moves its object to the mouse position,
 * whenever the player clicks the left mouse-button.
 */
public class MouseClickMover : MonoBehaviour {
    void Update() {
        // bool isLeftMouseButtonDown = Input.GetMouseButtonDown(0);      // Old UnityEngine.Input
        bool isLeftMouseButtonDown = Mouse.current.leftButton.wasPressedThisFrame;  // New InputSystem: Workflow 1
        if (isLeftMouseButtonDown) {
            // Vector3 mousePositionInScreenCoordinates = Input.mousePosition;   // Old UnityEngine.Input
            Vector3 mousePositionInScreenCoordinates = Mouse.current.position.ReadValue();   // New InputSystem: Workflow 1
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
