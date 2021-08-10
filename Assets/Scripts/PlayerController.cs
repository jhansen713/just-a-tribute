using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The PlayerController script is for recieving inputs from the player.
/// We would create an empty game object for each player and assign this script to it.
/// </summary>
public class PlayerController : MonoBehaviour {
    public GameObject playerToken; //Reference to the 3D object representing our player
    public float moveSpeed = 800.0f;

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

        //Run as long as this controller is active
        while (enabled) {
            //Move Variables
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            playerToken.GetComponent<Rigidbody>().AddForce(movement * moveSpeed * Time.deltaTime);

            //Shoot action
            if (Input.GetKeyDown(KeyCode.Space)) {
                yield return Shoot();
            }

            yield return null;
        }
    }

    private IEnumerator Shoot() {
        Debug.Log("Pew Pew!");
        yield return null;
	}

}