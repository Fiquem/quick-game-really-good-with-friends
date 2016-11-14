using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject focus;

    public float zDist = -10.0f;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(focus.transform.position.x, focus.transform.position.y, zDist);
	}
}
