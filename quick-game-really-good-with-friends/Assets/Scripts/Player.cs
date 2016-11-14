using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    InteractableSensor iSense;
    
	// Use this for initialization
	void Start () {
        iSense = GetComponentInChildren<InteractableSensor>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (CrossPlatformInputManager.GetButtonDown("Interact"))
        {
            Friend f = iSense.GetFriend();
            if (f != null)
            {
                f.talk();
            }
        }
	}
    
}
