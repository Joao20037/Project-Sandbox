using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    private void OnEnable()
    {
        Action_Attack.Attack += changeAnimation;
        Action_Attack.Attack += PushBackwards;
        Action_Attack.Attack += ChangeLife;
    }

    private void OnDisable()
    {
        Action_Attack.Attack -= changeAnimation;
        Action_Attack.Attack -= PushBackwards;
        Action_Attack.Attack -= ChangeLife;
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Red_class attributes = new Red_class();
        attributes.setAttack(5f);
        attributes.setShield(10f);
        attributes.setLife(45f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLife()
    {
        // Nao estou conseguindo pegar o attributes
    }

    public void PushBackwards()
    {
        _rigidbody.AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
    }
    public void changeAnimation()
    {
        // Fazer a animação de ataque, não fiz ainda porque sou muito ruim em fazer animações.
    }
}
