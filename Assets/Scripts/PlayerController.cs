using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	bool ShowWayPoints;
	public GameObject WayPoints;
	// Use this for initialization
	void Start () {
		ShowWayPoints = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(ShowWayPoints && transform.position.z < 22){
			HideWaypoints();
		} 
	}

	void HideWaypoints(){
		ShowWayPoints = false;
		WayPoints.SetActive(false);
	}
}
