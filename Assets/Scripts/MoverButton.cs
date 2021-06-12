using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverButton : MonoBehaviour
{
    public bool activated;
    public GameObject player;
    private void Start()
    {
        activated = false;
    }

    void Update()
    {
        var a = new Vector2(transform.position.x, transform.position.y);
        var b = new Vector2(player.transform.position.x, player.transform.position.y);

        if (Vector2.Distance(a, b) < 4)
        {
            if (Input.GetKeyDown("e"))
            {
                activated = !activated;

            }


        }

    }
}
