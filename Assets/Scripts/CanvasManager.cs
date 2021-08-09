using UnityEngine;
using System.Collections;

/// <summary>
/// Used to manage the User Display. We don't need to use this but it's good for showing Enable/Disable use
/// </summary>
public class CanvasManager : MonoBehaviour {
    public static CanvasManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        //EventManager.StartListening(EventManager.AttackEvent, UpdateDisplay);
    }

    private void OnDisable()
    {
        //EventManager.StopListening(EventManager.AttackEvent, UpdateDisplay);
    }
}
