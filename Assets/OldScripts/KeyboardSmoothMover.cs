using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object up/down
 * as long as the up/down arrow key is held pressed.
 */
public class KeyboardSmoothMover : MonoBehaviour {
    [Tooltip("Movement speed in meters per second")] [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // bool clickUp = Input.GetKey(KeyCode.UpArrow);  // Old UnityEngine.Input
        bool clickUp = Keyboard.current.upArrowKey.isPressed;  // Old UnityEngine.Input
        if (clickUp) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (Keyboard.current.downArrowKey.isPressed) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
