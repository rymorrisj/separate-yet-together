using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiCaller : MonoBehaviour
{
    public float parentX;
    public float parentY;
    public GameObject StuckTo;
    public Sprite show;
    private void Start()
    {

    }
    void Update()
    {

        //get parents global co-ord
        parentX = StuckTo.GetComponent<Transform>().position.x;
        parentY = StuckTo.GetComponent<Transform>().position.y;

        //stop rotating
        transform.position = new Vector2(parentX + 4, parentY + 4);
        transform.eulerAngles = new Vector3(0, 0, 0);


    }
}
