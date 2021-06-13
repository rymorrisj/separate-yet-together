using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMass : MonoBehaviour
{
    public int mass = 10;
    public int numOfBlobs = 0;

    private void Update()
    {

        if (isDead())
        {
            // TODO animation
            // restart level
            GetComponent<Dead>().NoHealth();
        }
        else
        {
            numOfBlobs = mass / 5;
        }
    }

    private bool isDead()
    {
        bool died = mass <= 0;
        return died;
    }
}
