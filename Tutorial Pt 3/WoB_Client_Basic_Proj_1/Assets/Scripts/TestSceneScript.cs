﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TestSceneScript : MonoBehaviour {
	public GameObject terrainNew;
	public Button btn;
	private Rect windowRect;
	// Use this for initialization
	void Start () {
		GameObject terrainOld = GameObject.Find ("MaasaiMara");
		Vector3 position = terrainOld.transform.position;
		Quaternion rotation = terrainOld.transform.rotation;
		Destroy(terrainOld);
		GameObject newTerrain =(GameObject) Instantiate (terrainNew , position , rotation);
		newTerrain.name = "new terrain";
		newTerrain.layer = 9;
		Button home = btn.GetComponent<Button> ();
		home.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick() {
		SceneManager.LoadScene("Login");
	}
	

}
