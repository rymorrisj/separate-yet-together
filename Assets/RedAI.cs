using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAI : MonoBehaviour
{
    private Rigidbody2D rb;
    public enum MoodEnum { idle, chase, attack };
    public MoodEnum mood;
    public float SightRange;
    public int ResetTime;
    public int speed;
    private Vector2 dir;
    public GameObject ReturnTo;
    public GameObject Player;


    void Start()
    {
        mood = MoodEnum.idle;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var a = new Vector2(transform.position.x, transform.position.y);
        var b = new Vector2(Player.transform.position.x, Player.transform.position.y);
        if (Vector2.Distance(a, b) > SightRange * 1.5)
        {
            mood = MoodEnum.idle;
        }

        if (Vector2.Distance(a, b) < SightRange)
        {
            mood = MoodEnum.chase;
        }
        if (mood == MoodEnum.chase)
        {
            dir = Player.transform.position - transform.position;
            dir = dir.normalized;
            rb.AddForce(dir * speed);
        }
        if (mood == MoodEnum.idle)
        {
            dir = ReturnTo.transform.position - transform.position;
            dir = dir.normalized;
            rb.AddForce(dir * speed);
        }

    }
}
