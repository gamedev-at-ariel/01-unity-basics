using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object one step up/down,
 * whenever the player clicks the up/down arrow key.
 */
public class KeyboardClickMover2 : MonoBehaviour {
    [Tooltip("Step size in meters")] [SerializeField]
    float stepSize = 1f;

    [SerializeField]
    KeyCode[] upKeys = { KeyCode.UpArrow };

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        foreach (KeyCode upKey in upKeys) {
            if (Input.GetKeyDown(upKey)) {
                // transform == GetComponent<Transform>()
                transform.position += new Vector3(0, stepSize, 0);
            }
        } 
        if (Input.GetKeyDown(downKey)) {
            transform.position += new Vector3(0, -stepSize, 0);
        }
    }
}
