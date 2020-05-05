using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object to the mouse position,
 * as long as the mouse-button is held.
 */
public class MouseSmoothMover : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButton(0)) {  // left button down
            Vector3 mousePositionInScreenCoordinates = Input.mousePosition;
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
