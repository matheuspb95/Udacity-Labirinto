using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {
	public GameObject PillarPrefab;
	public int MazeWidth, MazeHeight;
	// Use this for initialization
	void Start () {
		
		
	}

	public void CreateMaze(){
		while(transform.childCount > 0){
			GameObject.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		for(int x = 0; x < MazeWidth; x++){
			for(int z = 0; z < MazeHeight; z++){
				GameObject NewPillar = Instantiate(PillarPrefab);
				NewPillar.transform.parent = transform;
				NewPillar.transform.localPosition = new Vector3(-x * 5, 0, -z * 5);
				NewPillar.transform.localScale = Vector3.one * 100;
				int r = Random.Range(0,3);
				NewPillar.transform.eulerAngles = new Vector3(-90, 90 * r, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
