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
            mass = 20;
            massToDrop = 2;
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
        if (numOfBlobs % 5 != 0)
        {
            Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
            gameObject.transform.localScale -= -scaleChange;
        }

        if (IsDead())
        {
            GetComponent<Dead>().NoHealth(gameObject);
        }
    }

    public void GainMass(int gainValue)
    {
        mass += gainValue;
        if (numOfBlobs % 5 != 0)
        {
            Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
            gameObject.transform.localScale += scaleChange;
        }
    }

    public GameObject DropMass()
    {
        GameObject mass = Instantiate(massPrefab) as GameObject;
        mass.GetComponent<Value>().SetValue(massToDrop);
        return mass;
    }
}
