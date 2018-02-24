using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class TestSceneScript : MonoBehaviour {
		public GameObject terrainNew;
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
		
	}

	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width / 2 - 50 , 335, 100, 25), "Home")) {
			SceneManager.LoadScene("Login");
		}
	}
	

}
