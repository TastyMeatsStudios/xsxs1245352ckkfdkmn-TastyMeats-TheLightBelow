using UnityEngine;
using System.Collections;


/*
public static class GlobalField
{
    static Player player = new Player();
    static Enemy enemy = new Enemy();
}

public class monsterGen : MonoBehaviour
{

   
}

public class Player : MovingObject
{
    private void Update ()
    {
        if ()
    }
}

public class Main : MonoBehaviour
{

    public int eHealth = 0;
    public int eDamage = 0;
    public float eSpeed = 0;
    internal int ID = 0;

    private enum Mob { SKELETON = 0, DRAUGR, REDEAD, KRANEN };

    public void dothis()   //(int value, int eHealth, int eDamage, int eSpeed, int ID)
    {
        System.Random rnd = new System.Random();
        int value = rnd.Next(4);

        switch (value)
        {
            case (int)Mob.SKELETON:
                eHealth = 20;
                eDamage = 5;
                eSpeed = 15;
                ID++;
                break;

            case (int)Mob.DRAUGR:
                eHealth = 30;
                eDamage = 7;
                eSpeed = 8;
                ID++;
                break;
            case (int)Mob.REDEAD:
                eHealth = 30;
                eDamage = 7;
                eSpeed = 9;
                ID++;
                break;
            case (int)Mob.KRANEN:
                eHealth = 30;
                eDamage = 7;
                eSpeed = 10;
                ID++;
                break;
        }
        Debug.Log(eSpeed);
    }


    
        Player Play;
        Enemy Enem;
    
    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    // Used for regular updates (every frame)
    //  - Moving Non-Physics objects
    //  - Simple Timers
    //  - Receiving Input
    // Update Interval Times Vary

    void Update ()
    {
        e_CheckRange(10, 10, 10, 10);
        //e_Attack();
        CheckRange(10, 10, 10, 10);
        // Attack();

        dothis();
        CheckPress();
    }

    // Called consistantly every physics step
    //  - Ajusting Physics (Rigidbody) objects

    void fixedUpdate()
    {

    }
    // If you want to refer to in application buttons like "Green" then replace 'key' with 'button'
    void CheckPress()
    {
        if (Input.GetKeyDown(KeyCode.W)) // Make W
        {

        }
        if (Input.GetKeyDown(KeyCode.A)) // Make A
        {

        }
        if (Input.GetKeyDown(KeyCode.S)) // Make S
        {

        }
        if (Input.GetKeyDown(KeyCode.D)) // Make D
        {

        }
        if (Input.GetMouseButtonDown(0)) // Left Click
        {

        }
        if (Input.GetMouseButtonDown(1)) // Right Click
        {

        }
        if (Input.GetMouseButtonDown(2)) // Middle Click
        {

        }
    }

    bool e_CheckRange(int Ey, int Ex, int Py, int Px)
    {
        int Range = 10;
        bool isAttacking = false;

        int Ry = 0;
        Ry = Ey - Py;
        int Rx = 0;
        Rx = Ex - Px;

        if (Ry < 0)
        {
            Ry *= -1;
        }

        if (Rx < 0)
        {
            Rx *= -1;
        }

        if (Rx < Range && Ry < Range)
        {
            if (isAttacking == false)
            {
                isAttacking = true;
               // e_Attack();
                return true;
            }
            return true;
        }
        return false;
    }

    bool CheckRange(int Ey, int Ex, int Py, int Px)
    {
        int Range = 10;
        bool isAttacking = false;

        int Ry = 0;
        Ry = Ey - Py;
        int Rx = 0;
        Rx = Ex - Px;

        if (Ry < 0)
        {
            Ry *= -1;
        }

        if (Rx < 0)
        {
            Rx *= -1;
        }

        if (Rx < Range && Ry < Range)
        {
            if (isAttacking == false)
            {
                isAttacking = true;
               // e_Attack();
                return true;
            }
            return true;
        }
        return false;
    }

    void e_Attack()
    {
        // wait animation length
        int PHealth = Play.getHealth();
        int EHealth = Enem.getEHealth();

        CheckRange(10, 10, 10, 10); // change this to take in the location of player and enemy

    }

    void Attack()
    {
        int PHealth = Play.getHealth();
        int EHealth = Enem.getEHealth();

        CheckRange(10, 10, 10, 10); // change this to take in the location of player and enemy
    }

    void e_CheckAlive()
    {
        if (Enem.getEHealth() < 0)
        {

        }
    }

    void CheckAlive()
    {
        if (Play.getHealth() < 0)
        {

        }
    }
        
}

public class Player : MonoBehaviour
{
    public Player() { }

    public int getHealth() { return Health; }
    public int getDamage() { return Damage; }


    private int Health = 100;
    private int Damage = 10;
}

public class Enemy : MonoBehaviour
{
    public int getEHealth() { return eHealth; }
    public int getEDamage() { return eDamage; }


    private int eHealth = 50;
    private int eDamage = 10;
}

*/