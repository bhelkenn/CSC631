using UnityEngine;
using System.Collections;

public class TestSceneScript2 : MonoBehaviour {
	public GameObject dummy;
	private Vector3 screenPosition;
	private GameObject newAnimal;
	public Material animal1;
	public Material animal2;
	public Material animal3;
	// Use this for initialization
	void Start () {
				
				//Instantiate(ball,screenPosition,Quaternion.identity);

				for (var x = 0; x < 5; x++) {
						MakeAnimal (0);
				}
	
	}
	
	// Update is called once per frame
	void Update () {

				if (Input.GetKeyDown ("a")) {
						MakeAnimal (1);
				}

				if(Input.GetKeyDown ("s")){
						MakeAnimal (2);
				}

				if(Input.GetKeyDown ("d")){
						MakeAnimal (3);
				}
						
	
	}

		void MakeAnimal(int type = 0){
				screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0,Screen.width), Random.Range(-300,Screen.height), 40));
				screenPosition.y = Terrain.activeTerrain.SampleHeight(screenPosition);
				newAnimal = Instantiate(dummy, screenPosition, Quaternion.identity) as GameObject;
				//Debug.Log (newAnimal.transform.Find("Plane").GetComponent<Renderer>().material);
				if (type == 1) {
						
						newAnimal.transform.Find ("Plane").GetComponent<Renderer>().material = animal1;
				} else if (type == 2) {
						newAnimal.transform.Find ("Plane").GetComponent<Renderer> ().material = animal2;
				} else if (type == 3) {
						newAnimal.transform.Find ("Plane").GetComponent<Renderer> ().material = animal3;
				}
		}
}
