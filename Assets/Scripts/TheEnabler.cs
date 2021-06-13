using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnabler : MonoBehaviour
{
    public void pleaseStop()
    {

        GetComponent<PointAndShoot>().enabled = false;
        GetComponent<PlayerController>().enabled = false;
        GetComponent<PlayerJump>().enabled = false;

    }

    public void pleaseStart()
    {

        GetComponent<PointAndShoot>().enabled = true;
        GetComponent<PlayerController>().enabled = true;
        GetComponent<PlayerJump>().enabled = true;

    }
}
