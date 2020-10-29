using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Accelerates its object in a fixed acceleration.
 */
[RequireComponent(typeof(Mover))]
public class Accelerator : MonoBehaviour
{
    [Tooltip("Acceleration in meters/second^2")]
    [SerializeField]
    float acceleration = 1f;

    // Update is called once per frame
    void Update()
    {
         GetComponent<Mover>().AddSpeed(Time.deltaTime * acceleration);
    }
}
