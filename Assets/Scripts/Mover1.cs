using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour
{
    [Tooltip("How fast the spaceship moves, in meters per second.")]
    [SerializeField]
    Vector3 velocity = new Vector3(1, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += velocity * Time.deltaTime;
    }
}
