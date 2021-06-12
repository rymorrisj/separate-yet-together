using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject player;
    public string WhatlvlNext;

    // Update is called once per frame
    private void Update()
    {
        var a = new Vector2(transform.position.x, transform.position.y);
        var b = new Vector2(player.transform.position.x, player.transform.position.y);

        if (Vector2.Distance(a, b) < 4)
        //   if (other.gameObject == player)
        {
            Debug.Log("touching");
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("go");
                SceneManager.LoadScene(WhatlvlNext);
            }
        }
    }
}
