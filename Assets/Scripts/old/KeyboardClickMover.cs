using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object one step up/down,
 * whenever the player clicks the up/down arrow key.
 */
public class KeyboardClickMover : MonoBehaviour {
    [Tooltip("Step size in meters")] [SerializeField] float stepSize = 1f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame) {
            transform.position += new Vector3(0, stepSize, 0);
        } else if (Keyboard.current.downArrowKey.wasPressedThisFrame) {
            transform.position += new Vector3(0, -stepSize, 0);
        }
    }
}
