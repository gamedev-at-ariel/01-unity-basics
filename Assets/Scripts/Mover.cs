using UnityEngine;

/**
 *  This component moves its object right or left in a fixed speed.
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 1f;

    public void AddSpeed(float newSpeed) {
        speed += newSpeed;
    }

    // Start is called before the first frame update
    void Start() {
        //Debug.Log("Start");
        //transform.position = new Vector3(0, 0, 0); // Move object to origin of world
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("Update");
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0); // move right speed * Time.deltaTime meters.

        //NOTES:
        // a.    transform is equivalent to GetComponent<Transform>()
        // b.    position+=new Vector3(x,y,z) is equivalent to position = new Vector3(position.x+x,position.y+y,position.z+z)
    }
}
