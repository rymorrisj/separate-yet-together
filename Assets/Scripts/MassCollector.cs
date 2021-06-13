using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassCollector : MonoBehaviour
{
    public GameObject drainPrefab;
    public int totalMass = 0;
    public float timeOut = 3.0f;
    public Camera mainCamera;

    private GameObject activeObject;
    private int activeObjectMass;
    private GameObject drain;

    private void Update()
    {
        if (drain)
        {
            // if mass, move it
            // sound
            // destroy once mass touches drain
            // no mass, destroy drain
        }
    }

    public void CollectMassInDrain()
    {
        GameObject drain = Instantiate(drainPrefab) as GameObject;
        drain.transform.position = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 20, Screen.height - 20, 10));
    }

    public void CollectMassOnTimer(int enemyMass, GameObject passedObject)
    {
        activeObject = passedObject;
        activeObjectMass = enemyMass;
        Invoke("GatherMass", timeOut);
    }

    private void GatherMass()
    {
        totalMass += activeObjectMass;
        CollectMassInDrain();
        if (activeObject)
        {
            Destroy(activeObject);
        }
    }
}
