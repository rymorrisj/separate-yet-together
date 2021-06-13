using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAI : MonoBehaviour
{
    private Rigidbody2D rb;
    public enum MoodEnum { idle, chase, attack };
    public MoodEnum mood;
    public float SightRange;
    public float AttackRange;
    private float AttackTime;
    public float AttackTimeMax;
    public float AttackResetMax;
    private float AttackReset;
    public int AttackSpeed;
    public int speed;
    private float chargesReset;
    public float chargesResetMax;

    private bool Attacking;
    private Vector2 dir;
    public GameObject ReturnTo;
    public GameObject Player;


    void Start()
    {
        mood = MoodEnum.idle;
        rb = GetComponent<Rigidbody2D>();
        Attacking = false;
        AttackReset = 0.1f;
        AttackTime = AttackTimeMax;
        chargesReset = chargesResetMax;
    }

    void Update()
    {

        if (Attacking)
        {
            if (chargesReset > 0)
            {
                rb.AddForce(dir * AttackSpeed);
                chargesReset -= Time.deltaTime;
            }
            else if (chargesReset <= 0)
            {
                Pounce();
            }

            return;
        }
        var a = new Vector2(transform.position.x, transform.position.y);
        var b = new Vector2(Player.transform.position.x, Player.transform.position.y);
        if ((Vector2.Distance(a, b) > SightRange * 1.5) && Attacking == false)
        {
            mood = MoodEnum.idle;
        }

        if ((Vector2.Distance(a, b) < SightRange) && Attacking == false)
        {
            mood = MoodEnum.chase;
        }
        if (Vector2.Distance(a, b) < AttackRange)
        {
            mood = MoodEnum.attack;
        }
        if (mood == MoodEnum.chase)
        {
            dir = Player.transform.position - transform.position;
            dir = dir.normalized;
            rb.AddForce(dir * speed);
        }
        //timer for attack reset
        if (AttackReset > 0)
        {
            AttackReset -= Time.deltaTime;
        }

        if ((mood == MoodEnum.attack) && (AttackReset < 0))
        {
            Pounce();
            Attacking = true;
        }
        if (mood == MoodEnum.idle)
        {
            dir = ReturnTo.transform.position - transform.position;
            dir = dir.normalized;
            rb.AddForce(dir * speed);
        }

    }

    void Pounce()
    {
        AttackReset = AttackResetMax;
        AttackTime = AttackTimeMax;
        Attacking = false;
        chargesReset = chargesResetMax;
    }


}
