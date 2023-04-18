using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.lightGoOn += lightGoOn;
        EventBus.Current.lightGoOff += lightGoOff;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        
    public void lightGoOn()
    {
        gameObject.GetComponent<Light>().intensity = 3;

    }

    public void lightGoOff()
    {
        gameObject.GetComponent<Light>().intensity = 0;

    }

    void OnDestroy()
    {
        EventBus.Current.lightGoOn -= lightGoOn;
        EventBus.Current.lightGoOff -= lightGoOff; 
    }

}
