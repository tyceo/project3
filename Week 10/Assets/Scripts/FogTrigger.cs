using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          //  other.gameObject.GetComponent<PlayerStats>().RemoveHP(damageValue);
        }
    }
}
