using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    //[SerializeField] private int vida;
    //[SerializeField] private bool isNear;

    //[SerializeField] private string[] items;

    [SerializeField] private bool isJumping;
    [SerializeField] private int lives;
    [SerializeField] private bool isAlive;
    [SerializeField] private bool isEnemyNear;

    // Start is called before the first frame update
    void Start()
    {

        //do
        //{
        //    vida--;
        //    print("Levou dano");
        //} while (vida > 0 && isNear);

        //if(vida <= 0)
        //{
        //    print("MORREU VACILÃO");
        //}

        //for (int i = 0; i < items.Length; i++)
        //{
        //    print(items[i]);
        //}

    }

    // Update is called once per frame
    void Update()
    {

        VerifyJump();
        if(isEnemyNear)
        {
            TakeDamage();
        }
        if(!isAlive)
        {
            print("O jogador morreu");
        }

    }

    void VerifyJump()
    {
        if (isJumping)
        {
            print("O jogador pulou");
        }
    }

    void TakeDamage()
    {
        lives--;
        if(lives == 0)
        {
            isAlive = false;
        }
    }

}
