using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ConnectionController : MonoBehaviour {

    public Text[] uiText;
	// Use this for initialization
	void Start () {
	    //make the api calls here
	}
	
	// Update is called once per frame
	void Update () {
	    //if there are many whenever press spacebar go to the next one in the array
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Check");
        }
	}
}
