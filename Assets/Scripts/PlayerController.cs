using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The PlayerController script is for recieving inputs from the player.
/// We would create an empty game object for each player and assign this script to it.
/// </summary>
public class PlayerController : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(InputListener());
    }

    // Update is called once per frame
    void Update() {

    }

    /// <summary>
    /// Called by Start method to listen for inputs
    /// </summary>
    /// <returns></returns>
    private IEnumerator InputListener() {
        Vector3 vector;

        //Run as long as this controller is active
        while (enabled) {
            //Tile Cursor is only active when Action Canvas the is NOT displayed
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                //Move(new Vector3() in Up Direction)
            } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                //Move(new Vector3() in Down Direction)
            } else if (Input.GetKeyDown(KeyCode.RightArrow)) {

            } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {

            } else if (Input.GetKeyDown(KeyCode.Space)) {
                yield return Shoot();
            }
        }
    }

    private IEnumerator Shoot() {
        Debug.Log("Pew Pew!");
        yield return null;
	}
}