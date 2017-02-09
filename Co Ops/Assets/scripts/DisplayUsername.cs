using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUsername : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<UnityEngine.UI.Text> ().text = "Welcome, " + Social.localUser.userName +"!";
	}

}
