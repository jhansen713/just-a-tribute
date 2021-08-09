using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// Event Manager to decouple events from objects. IE if we shoot a bullet we trigger and event
/// And the Canvas updates the display, the inventory is updated, maybe an enemy tries to avoid, etc...
/// </summary>

//[System.Serializable]
//public class AttackEvent : UnityEvent<AttackData> { } //Example Event where Attack Data is stored

public class EventManager : MonoBehaviour
{
    private Dictionary<string, UnityEvent> eventDictionary; //Stores a list of events used in the game
    public static EventManager instance;


    //public static AttackEvent OnAttack = new AttackEvent(); Example Attack Event

    /// <summary>
    /// Called at the start of a scene. Used to create a singleton of EventManager
    /// </summary>
    void Awake() {
        if (instance == null) {
            instance = this;
            Init(); //initialize the event dictionary
        } else if (instance != this) {
            Destroy(gameObject);   //destroy this instance
        }
    }

    /// <summary>
    /// Called to initialize a new Dictionary for storing events
    /// </summary>
    private void Init() {
        if (eventDictionary == null) {
            eventDictionary = new Dictionary<string, UnityEvent>();
        }
    }

    /// <summary>
    /// Called to subscribe to an event.
    /// using a new class for every event type
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="listener"></param>
    public static void StartListening(UnityEvent unityEvent, UnityAction listener) {
        unityEvent.AddListener(listener);
    }

    //Example Attack Event Listener
    //public static void StartListening(UnityEvent<AttackData> unityEvent, UnityAction<AttackData> listener) {
    //    unityEvent.AddListener(listener);
    //}


    /// <summary>
    /// Called to unsubscribe to an event (MUST BE IMPLEMENTED OR ELSE WE CAN RUN INTO MEM LEAKS)
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="listener"></param>
    public static void StopListening(UnityEvent unityEvent, UnityAction listener) {
        if (instance == null)
            return; //Already destroyed our singleton. Nothing to do

        unityEvent.RemoveListener(listener);
    }

    //Example Attack Event Unsubscribe
    //public static void StopListening(UnityEvent<AttackData> unityEvent, UnityAction<AttackData> listener) {
    //    if (instance == null)
    //        return; //Already destroyed our singleton. Nothing to do

    //    unityEvent.RemoveListener(listener);
    //}
}
