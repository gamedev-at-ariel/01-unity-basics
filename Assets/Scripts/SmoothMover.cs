using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object up/down
 * as long as the up/down arrow key is held pressed.
 */
public class SmoothMover : MonoBehaviour {
    [Tooltip("Movement speed in meters per second")] [SerializeField] float speed = 1f;

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
        if (moveUp.IsPressed()) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (moveDown.IsPressed()) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        } else if (moveTo.IsPressed()) {
            Vector2 mousePositionInScreenCoordinates = moveToLocation.ReadValue<Vector2>();  
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
