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

    GameObject speechBubble;

    // Use this for initialization
    void Start () {
        speechBubble = Instantiate(Resources.Load("SpeechBubble-Small"), speechBubbleAnchor.transform, false) as GameObject;
        speechBubble.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

    }

    //void OnGUI()
    //{
    //    if (talking)
    //    {
    //        Vector3 getPixelPos = Camera.main.WorldToScreenPoint(speechBubbleAnchor.transform.position);
    //        getPixelPos.y = Screen.height - getPixelPos.y;
            
    //        GUI.Label(new Rect(getPixelPos.x, getPixelPos.y, 200f, 100f), selectedText);
    //        //print(selectedText);
    //    }
    //}

    public void talk()
    {
        
        if (speech.Length > 0) {
            talking = true;
            speechBubble.SetActive(true);

            selectedText = speech[speechIndex];
            speechBubble.GetComponentInChildren<TextMesh>().text = selectedText;

            speechIndex++;
            if (speechIndex >= speech.Length)
            {
                speechIndex = 0;
            }
        }
    }
}
