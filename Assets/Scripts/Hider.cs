using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Hides its object when the user clicks H;
 * reveals it when the use clicks R.
 */
public class Hider : MonoBehaviour {

    private Renderer myRenderer;
    private void Start() {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.H)) {
            myRenderer.enabled = false;
        } else if (Input.GetKeyDown(KeyCode.R)) {
            myRenderer.enabled = true;
        }
    }
}
