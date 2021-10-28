using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    [SerializeField]
    [Tooltip("how fast the object moves, in meters per second")]
    Vector3 velocity = new Vector3(0, 1, 0);

    int privateInformation = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        t.position += velocity * Time.deltaTime;
    }
}
