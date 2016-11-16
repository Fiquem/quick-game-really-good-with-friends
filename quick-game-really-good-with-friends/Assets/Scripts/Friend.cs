using UnityEngine;
using System.Collections;

public class Friend : MonoBehaviour {

    public GameObject speechBubbleAnchor;
    public string[] speech =
    {
        "...",
        "... ...",
        "..?"
    };

    int speechIndex = 0;
    string selectedText = "";
    bool talking = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnGUI()
    {
        if (talking)
        {
            Vector3 getPixelPos = Camera.main.WorldToScreenPoint(speechBubbleAnchor.transform.position);
            getPixelPos.y = Screen.height - getPixelPos.y;
            
            GUI.Label(new Rect(getPixelPos.x, getPixelPos.y, 200f, 100f), selectedText);
            //print(selectedText);
        }
    }

    public void talk()
    {
        if (speech.Length > 0) {
            talking = true;
            selectedText = speech[speechIndex];
            speechIndex++;
            if (speechIndex >= speech.Length)
            {
                speechIndex = 0;
            }
        }
    }
}
