using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractableSensor : MonoBehaviour {

    public List<GameObject> overlappingGOs;

	// Use this for initialization
	void Start () {
        overlappingGOs = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        overlappingGOs.Add(other.gameObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        overlappingGOs.Remove(other.gameObject);
    }

    public Friend GetFriend()
    {
        foreach (GameObject go in overlappingGOs)
        {
            Friend f = go.GetComponent<Friend>();
            if (f!= null)
            {
                return f;
            }
        }

        return null;
    }
}
