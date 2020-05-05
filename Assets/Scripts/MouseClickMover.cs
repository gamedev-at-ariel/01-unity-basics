using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object to the mouse position,
 * whenever the player clicks the left mouse-button.
 */
public class MouseClickMover : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButtonDown(0)) {  // left button down
            Vector3 mousePositionInScreenCoordinates = Input.mousePosition;
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
