using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

    //position key randonly.
    public int minPosX, maxPosX, minPosZ, maxPosZ;
    //Instantiate coin around key, to help player find it.
    public GameObject CoinPrefab;
    void Start(){

        int posx = Random.Range(minPosX / 5, maxPosX / 5) * 5;
        int posz = Random.Range(minPosZ / 5, maxPosZ / 5) * 5;
        transform.position = new Vector3(posx, 2.5f, posz);

        //Instantiate coin around key, to help player find it.
        for(int x = posx-10; x <= posx+10; x+=5){
            for(int z = posz-10; z <= posz+10; z+=5){
                Instantiate(CoinPrefab, new Vector3(x, 0.3f, z), Quaternion.Euler(-90, 0, 0));
            }
        }
    }

    [Space(4)]
    //Animate key with floating and rotation
    public float FloatingTime, RotationTime;
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.time * FloatingTime) / 2) + 2, transform.position.z);
        transform.rotation = Quaternion.Euler(-90, Time.time * RotationTime, 0);
	}

    [Space(4)]
    public GameObject KeyPoofPrefab;
    public Door DoorScript;
    
	public void OnKeyClicked()
	{
        Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90,0,0));
        DoorScript.Unlock();
        GameObject.Destroy(this.gameObject);
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
