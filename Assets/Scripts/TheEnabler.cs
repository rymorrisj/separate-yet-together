using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnabler : MonoBehaviour
{
    private GameObject THISGUY;

    private void Start()
    {
        gameObject.name = GetInstanceID().ToString();
        THISGUY = GameObject.Find(gameObject.name);
    }
    public void pleaseStop(string name)
    {
        if (name == THISGUY.name)
        {
            THISGUY.GetComponent<PointAndShoot>().enabled = false;
            THISGUY.GetComponent<PlayerController>().enabled = false;
            THISGUY.GetComponent<PlayerJump>().enabled = false;
        }
    }

    public void pleaseStart(string name)
    {
        if (name == THISGUY.name)
        {
            THISGUY.GetComponent<PointAndShoot>().enabled = true;
            THISGUY.GetComponent<PlayerController>().enabled = true;
            THISGUY.GetComponent<PlayerJump>().enabled = true;
        }
    }
}
