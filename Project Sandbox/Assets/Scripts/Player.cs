using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnEnable()
    {
        Action_Attack.Attack += changeAnimation;
    }

    private void OnDisable()
    {
        Action_Attack.Attack -= changeAnimation;
    }


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

    public void changeAnimation()
    {
        // Fazer a animação de ataque, não fiz ainda porque sou muito ruim em fazer animações.
    }
}
