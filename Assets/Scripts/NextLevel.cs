using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string WhatlvlNext;
    private bool canUse = false;

    private void Update()
    {
        if (canUse)
        {
            if (Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene(WhatlvlNext);
            }
        }

    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canUse = true;
        }
    }
}
