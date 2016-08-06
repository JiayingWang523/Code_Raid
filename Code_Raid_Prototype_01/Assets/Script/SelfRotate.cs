using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour {

    public float rotateSpeed = 30.0f;

    private Transform transform;

    // Use this for initialization
    void Start () {
        transform = this.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(transform.up, rotateSpeed * Time.deltaTime);
	}
}
