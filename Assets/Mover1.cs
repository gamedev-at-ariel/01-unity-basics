using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This component moves its object in a pre-specified speed.
 */
public class Mover1 : MonoBehaviour
{
    [SerializeField]
    Vector3 speed = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += Time.deltaTime * speed;
    }
}
