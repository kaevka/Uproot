using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public class WeaponHolder {
        public string name; //gun name
        public GameObject gunGO; // go weapon
        public bool isPresent; // weapon is true
    }
public WeaponHolder[] weapons; // massive with weapons
public int currentWeapon = 0; // current weapon in arms
 
// method picking up weapon and releasing it in player arms
void OnWeaponPickup(string _name) {
    foreach(WeaponHolder wh in weapons)
    if (wh.name == _name)
    wh.isPresent = true;
}
 
void Update() {
    int wpn = -1;
    // if(OnCollisionEnter2D = true)
    // {
    //     if (Input.GetKeyDown(KeyCode.Alpha1)) wpn = 0;
    //     if (Input.GetKeyDown(KeyCode.Alpha2)) wpn = 1;
    //     if (Input.GetKeyDown(KeyCode.Alpha3)) wpn = 2;
    //     if (Input.GetKeyDown(KeyCode.Alpha4)) wpn = 3;
    //     if (Input.GetKeyDown(KeyCode.Alpha5)) wpn = 4;
    //     if (wpn >= 0) {
    //     weapons[currentWeapon].gunGO.SetActive(false); // unable current
    //     weapons[wpn].gunGO.SetActive(true); // enable current
    //     currentWeapon = wpn; // remember current
    // }
 }
}
