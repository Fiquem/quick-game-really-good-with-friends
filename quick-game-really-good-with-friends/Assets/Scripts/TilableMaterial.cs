using UnityEngine;
using System.Collections;
using UnityEditor;


[ExecuteInEditMode]
public class TilableMaterial : MonoBehaviour {

	void Awake() {
		GetComponent<MeshRenderer> ().sharedMaterial.mainTextureScale = new Vector2 (transform.localScale.x, transform.localScale.y);
		GetComponent<MeshRenderer> ().sharedMaterial.mainTextureOffset = new Vector2 (transform.localScale.x/transform.localScale.y, transform.localScale.y/transform.localScale.y);
	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		GetComponent<MeshRenderer> ().sharedMaterial.mainTextureScale = new Vector2 (transform.localScale.x, transform.localScale.y);
		GetComponent<MeshRenderer> ().sharedMaterial.mainTextureOffset = new Vector2 (transform.position.x + transform.localScale.x/2, transform.position.y + transform.localScale.y/2);
	}


}
