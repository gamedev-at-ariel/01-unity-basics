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
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField][Tooltip("Move the player to the location of 'moveToLocation'.")]
    InputAction moveTo = new InputAction(type: InputActionType.Button); 

    [SerializeField][Tooltip("Determine the location to 'moveTo'.")]
    InputAction moveToLocation = new InputAction(type: InputActionType.Value, expectedControlType: "Vector2");

    void OnEnable()  {
        moveUp.Enable();
        moveDown.Enable();
        moveTo.Enable();
        moveToLocation.Enable();
    }

    void OnDisable()  {
        moveUp.Disable();
        moveDown.Disable();
        moveTo.Disable();
        moveToLocation.Disable();
    }

    void Update() {
        if (moveUp.WasPressedThisFrame()) {
            transform.position += new Vector3(0, stepSize, 0);
        } else if (moveDown.WasPressedThisFrame()) {
            transform.position += new Vector3(0, -stepSize, 0);
        } else if (moveTo.WasPressedThisFrame()) {
            Vector2 mousePositionInScreenCoordinates = moveToLocation.ReadValue<Vector2>();  
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
