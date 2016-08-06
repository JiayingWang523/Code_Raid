using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        float x = character.transform.position.x;
        float y = character.transform.position.y;
        float z = character.transform.position.z;
        y = y + 25;
        z = z - 30;
        Vector3 v = new Vector3(x, y, z);
        transform.position = v;
    }
}
