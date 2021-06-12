using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMass : MonoBehaviour
{
    public int mass = 10;
    public int numOfBlobs = 0;

    private void Update()
    {
        numOfBlobs = mass / 5;
    }
}
