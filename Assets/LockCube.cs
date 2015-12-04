﻿using UnityEngine;
using System.Collections;

public class LockCube : MonoBehaviour {

	public int Key;
	public GameObject Door;

	// Use this for initialization
	void OnValidate () {
		gameObject.GetComponent<TextMesh> ().text = Key.ToString ();
	}

	void Start() {

	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<Player> ().keys.Contains (Key)) {
			Door.GetComponent<UnlockableDoor>().counter++;
			Destroy(gameObject);
		}
	}
}
