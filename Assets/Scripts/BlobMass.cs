using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMass : MonoBehaviour
{
    public int mass = 0;
    public int massToDrop = 0;
    public int numOfBlobs = 0;
    public GameObject massPrefab;
    private bool isPlayer = false;

    private void Start()
    {
        string objectTag = gameObject.tag;
        if (objectTag == "Player")
        {
            isPlayer = true;
            mass = 10;
            massToDrop = 1;
        }
        else if (objectTag == "Enemy")
        {
            mass = 5;
            massToDrop = 2;
        }
    }

    private void Update()
    {

        if (IsDead())
        {
            GetComponent<Dead>().NoHealth(gameObject);
        }

        if (isPlayer)
        {
            numOfBlobs = mass / 5;
        }
    }

    public bool IsDead()
    {
        bool died = mass <= 0;
        return died;
    }

    public void LoseMass(int loseValue)
    {
        mass -= loseValue;
        if (IsDead())
        {
            GetComponent<Dead>().NoHealth(gameObject);
        }
    }

    public void GainMass(int gainValue)
    {
        mass += gainValue;
    }

    public GameObject DropMass()
    {
        GameObject mass = Instantiate(massPrefab) as GameObject;
        mass.GetComponent<Value>().SetValue(massToDrop);
        return mass;
    }
}
