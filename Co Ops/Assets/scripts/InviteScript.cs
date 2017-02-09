using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi.Multiplayer;
using UnityEngine.UI;

public class InviteScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		this.GetComponent<Button>().onClick.AddListener(InviteClickEvent);
	}

	void InviteClickEvent() {
		const int MaxOpponents = 7;
		const int MinOpponents = 1;
		const int variant = 0;
		PlayGamesPlatform.Instance.TurnBased.CreateWithInvitationScreen (MinOpponents, MaxOpponents, variant, OnMatchStarted);
	}
	
	void OnMatchStarted(bool success, TurnBasedMatch match) {
		if (success) {
			
		} else {

		}

	}
}
