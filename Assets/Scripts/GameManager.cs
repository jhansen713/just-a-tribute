using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Player Data that needs to persist across scenes. Think experience points, inventory, etc...
/// This is a singleton as there can only be one GameManager in a scene
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //Gives us access to the GameManager from any script

    // Awake is called at the start of a scene.
    void Awake()
    {
        //Insure only one instance is present
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        Initialize();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
	/// This is where we can load a JSON file from a save or configure
	/// </summary>
	public void Initialize() {
		
	}
}
