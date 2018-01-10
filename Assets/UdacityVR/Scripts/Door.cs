using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    bool unlocked, opening;
    public AudioSource OpenDoor, LockedDoor;
    public float EndPositionY, OpeningTime;
    float StartPositionY, StartTime, t;
    void Update() {
        if(opening){
            float posy = Mathf.Lerp(StartPositionY, EndPositionY, (Time.time - StartTime) / OpeningTime);
            transform.position = new Vector3(transform.position.x, posy, transform.position.z);
        }
    }

    public void OnDoorClicked() {
        if(unlocked){
            opening = true;
            StartTime = Time.time;
            StartPositionY = transform.position.y;
            OpenDoor.Play();
        } else {
            LockedDoor.Play();
        }
    }

    public void Unlock()
    {
        unlocked = true;
    }
}
