using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Red_class attributes = new Red_class();
        attributes.setAttack(10f);
        attributes.setShield(5f);
        attributes.setLife(50f);
        Debug.Log(attributes._life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
