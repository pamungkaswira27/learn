using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int playerDamage = 100;
    public int enemyHealth = 200;
    public string id;

    public const float PHI = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        Looping();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AttackEnemy(int damage)
    {
        enemyHealth = enemyHealth - damage;
    }

    void Conditional()
    {
        if (enemyHealth <= 0)
        {
            // statement jika kondisi terpenuhi
            Debug.Log("WIN");
        }
        else if (enemyHealth <= 50)
        {
            Debug.Log("Enemy Rage");
        }
        else
        {
            // statement jika kondisi tidak terpenuhi
            Debug.Log("Battle");
        }

        switch (id)
        {
            case "A":
                Debug.Log("WIN");
                break;
            case "B":
                Debug.Log("Enemy Rage");
                break;
            default:
                Debug.Log("Battle");
                break;
        }
    }

    void Looping()
    {
        int counter = 11;
        int lap = 3;
        bool isAlive = true;

        //while (isAlive)
        //{
        //    // Statement yang akan diulang
        //    counter++; // counter = counter + 1;
        //}

        //do
        //{
        //    // Statement yang akan diulang
        //    counter++; // counter = counter + 1;
        //}
        //while (counter <= 10);

        int[] arrayInt = { 4, 5, 6 };

        //for (int i = 0; i < 5; i++)
        //{
        //    // Statement yang akan diulang
        //    Debug.Log("Perulangan ke-" + i);
        //}

        foreach (int angka in arrayInt)
        {
            Debug.Log(angka);
        }
    }
}
