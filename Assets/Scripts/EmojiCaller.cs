using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiCaller : MonoBehaviour
{
    private float parentX;
    private float parentY;
    public float offsetX;
    public float offsetY;
    public GameObject StuckTo;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    private void Start()
    {

    }
    void Update()
    {

        //get parents global co-ord
        parentX = StuckTo.GetComponent<Transform>().position.x;
        parentY = StuckTo.GetComponent<Transform>().position.y;


        //stop rotating
        transform.position = new Vector2(parentX + offsetX, parentY + offsetY);
        transform.eulerAngles = new Vector3(0, 0, 0);


    }
    // clear sprite
    public void shownone()
    { GetComponent<SpriteRenderer>().sprite = null; }
    // trigger to set the sprite on the renderer
    public void show1()
    { GetComponent<SpriteRenderer>().sprite = sprite1; }
    public void show2()
    { GetComponent<SpriteRenderer>().sprite = sprite2; }
    public void show3()
    { GetComponent<SpriteRenderer>().sprite = sprite3; }

}
