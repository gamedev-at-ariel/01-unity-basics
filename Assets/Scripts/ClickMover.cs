using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object one step up/down,
 * whenever the player clicks a key. 
 * The key is customizable via the editor.
 */
public class ClickMover : MonoBehaviour {
    [Tooltip("Step size in meters")] [SerializeField] float stepSize = 1f;

    [SerializeField]
    InputAction moveUp;

    [SerializeField]
    InputAction moveDown;

    [SerializeField][Tooltip("Move the player to the place where the click occured.")]
    InputAction moveHere; 

    void OnEnable()  {
        moveUp.Enable();
        moveDown.Enable();
        moveHere.Enable();
    }

    void OnDisable()  {
        moveUp.Disable();
        moveDown.Disable();
        moveHere.Disable();
    }

    void Update() {
        if (moveUp.WasPressedThisFrame()) {
            transform.position += new Vector3(0, stepSize, 0);
        } else if (moveDown.WasPressedThisFrame()) {
            transform.position += new Vector3(0, -stepSize, 0);
        } else if (moveHere.WasPressedThisFrame()) {
            Vector2 mousePositionInScreenCoordinates = moveHere.ReadValue<Vector2>();  
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
