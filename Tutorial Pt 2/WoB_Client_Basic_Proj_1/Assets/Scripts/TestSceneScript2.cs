using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestSceneScript2 : MonoBehaviour {
	public GameObject dummy;
	private Vector3 screenPosition;
	private GameObject newAnimal;
	public Material animal1;
	public Material animal2;
	public Material animal3;
	public Text scoreboardDummy;
	public Text scoreboardAnimal1;
	public Text scoreboardAnimal2;
	public Text scoreboardAnimal3;
	private int dummyCount;
	private int animal1Count;
	private int animal2Count;
	private int animal3Count;

	// Use this for initialization
	void Start () {
		dummyCount = animal1Count = animal2Count = animal3Count = 0;
		for (var x = 0; x < 5; x++) {
			MakeAnimal (0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a")) {
			MakeAnimal (1);
		}
		if (Input.GetKeyDown ("s")) {
			MakeAnimal (2);
		}
		if (Input.GetKeyDown ("d")) {
			MakeAnimal (3);
		}

		UpdateScoreboard (scoreboardDummy, dummyCount);
		UpdateScoreboard (scoreboardAnimal1, animal1Count);
		UpdateScoreboard (scoreboardAnimal2, animal2Count);
		UpdateScoreboard (scoreboardAnimal3, animal3Count);
	}

	void MakeAnimal(int type) {
		screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0,Screen.width), Random.Range(-300,Screen.height), 40));
		screenPosition.y = Terrain.activeTerrain.SampleHeight(screenPosition);
		newAnimal = Instantiate(dummy, screenPosition, Quaternion.identity) as GameObject;

		if (type == 1) {
			newAnimal.transform.Find ("Plane").GetComponent<Renderer> ().material = animal1;
			animal1Count++;
		} else if (type == 2) {
			newAnimal.transform.Find ("Plane").GetComponent<Renderer> ().material = animal2;
			animal2Count++;
		} else if (type == 3) {
			newAnimal.transform.Find ("Plane").GetComponent<Renderer> ().material = animal3;
			animal3Count++;
		} else {
			dummyCount++;
		}
	}

	void UpdateScoreboard(Text scoreboard, int count) {
		if (count > 0) {
			if (!scoreboard.enabled) scoreboard.enabled = true;
			scoreboard.text = scoreboard.name + ": " + count.ToString();
		} else {
			scoreboard.enabled = false;
		}
	}
}
