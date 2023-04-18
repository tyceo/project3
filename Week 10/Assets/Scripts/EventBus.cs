using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
 

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    public static EventBus Current { get { return
    _current; } }

    private void Awake()
    {
    if (_current != null && _current != this)
    {
        Destroy(this.gameObject);
    } else {
        _current = this;
    }
    }
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

// This declares the official event
/*public event Action eventName;
// This is a function to ‘trigger’ the event
public void eventNameTrigger()
{
 // this line should match what you called the event at the start
 eventName();
}
*/

public event Action lightGoOn;
public void lightGoOnTrigger()
{
    lightGoOn();
} 
public event Action lightGoOff;
public void lightGoOffTrigger()
{
    lightGoOff();
} 

}
