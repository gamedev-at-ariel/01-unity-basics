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
    InputAction moveUp;

    [SerializeField]
    InputAction moveDown;

    void OnEnable()  {
        moveUp.Enable();
        moveDown.Enable();
    }

    void OnDisable()  {
        moveUp.Disable();
        moveDown.Disable();
    }

    void Update() {
        if (moveUp.IsPressed()) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (moveDown.IsPressed()) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
