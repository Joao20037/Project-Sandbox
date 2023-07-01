using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Attack : MonoBehaviour
{
    public static Action Attack;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Attack?.Invoke();
        }   
    }
}
