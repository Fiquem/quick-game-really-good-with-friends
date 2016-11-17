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

    GameObject speechBubble_small;
    GameObject speechBubble_large;

    // Use this for initialization
    void Start () {
        speechBubble_small = Instantiate(Resources.Load("SpeechBubble-Small"), speechBubbleAnchor.transform, false) as GameObject;
        speechBubble_large = Instantiate(Resources.Load("SpeechBubble-Large"), speechBubbleAnchor.transform, false) as GameObject;
        speechBubble_small.SetActive(false);
        speechBubble_large.SetActive(false);
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
            

            selectedText = speech[speechIndex];

            speechBubble_small.SetActive(false);
            speechBubble_large.SetActive(false);

            if (selectedText.Length > 4)
            {
                speechBubble_large.GetComponentInChildren<TextMesh>().text = selectedText;
                speechBubble_large.SetActive(true);
            }
            else
            {
                speechBubble_small.GetComponentInChildren<TextMesh>().text = selectedText;
                speechBubble_small.SetActive(true);
            }

            speechIndex++;
            if (speechIndex >= speech.Length)
            {
                speechIndex = 0;
            }
        }
    }
}
