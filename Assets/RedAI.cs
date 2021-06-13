using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAI : MonoBehaviour
{
    // Start is called before the first frame update
    enum mood
    { idle, chase, attack };


    void Start()
    {
        mood mymood;
        mymood = mood.idle;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
