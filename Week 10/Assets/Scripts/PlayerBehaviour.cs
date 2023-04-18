using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            EventBus.Current.lightGoOnTrigger();
        }

         if (Input.GetKeyDown("o"))
        {
            EventBus.Current.lightGoOffTrigger();
        }
    }
}
