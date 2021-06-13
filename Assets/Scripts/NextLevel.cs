using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string WhatlvlNext;
    private bool canUse = false;
    public GameObject boss;

    private void Update()
    {
        if (canUse && !boss)
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
