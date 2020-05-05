using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
