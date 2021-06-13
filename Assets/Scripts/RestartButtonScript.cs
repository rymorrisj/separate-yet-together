using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButtonScript : MonoBehaviour
{
    public string CurrentLevel;


    public void OnMouseOver()
    {

        GetComponent<EmojiCaller>().show2();
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(CurrentLevel);
        }
    }
    public void OnMouseExit()
    {

        GetComponent<EmojiCaller>().show1();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
