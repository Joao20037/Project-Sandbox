using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_class : Abstract_class
{

    public float _life;
    public float _attack;
    public float _shield;
    
    public void setLife(float amount)
    {
        _life = amount;

    }

    public void setAttack(float amount)
    {
        _attack = amount;
    }

    public void setShield(float amount)
    {
        _shield = amount;
    }



    public override void Morrer()
    {
        if (_life < 0)
        {
            Destroy(gameObject);
        }
    }
}
