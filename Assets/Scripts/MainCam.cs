using UnityEngine;
using System.Collections;

public class MainCam : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Camera>().orthographicSize = (Screen.height / 2.0f);	

	}
	
	
}
