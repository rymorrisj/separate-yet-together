using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSwitcher : MonoBehaviour
{
    public List<GameObject> players = new List<GameObject>();
    private int currentPlayer = 0;
    private bool isSwitchingCharacter = false;
    void FixedUpdate()
    {
        if (Input.GetButton("Submit") && isSwitchingCharacter != true)
        {
            Debug.Log("switching");
            if (players.Count >= 1)
            {
                Debug.Log("return switching");
                return;
            }
            isSwitchingCharacter = true;
            GameObject activePlayer = players[currentPlayer];
            disablePlayer(activePlayer);

            if (currentPlayer == players.Count)
            {
                currentPlayer = 0;
            }
            else
            {
                currentPlayer++;
            }

            activePlayer = players[currentPlayer];
            Debug.Log("activated Player");
            activePlayer.GetComponent<PlayerJump>().enabled = true;
            activePlayer.GetComponent<PointAndShoot>().enabled = true;
            activePlayer.GetComponent<PlayerController>().enabled = true;
        }

        if (Input.GetButton("Submit") != true)
        {
            isSwitchingCharacter = false;
        }
    }

    public void AddPlayer(GameObject newPlayer)
    {
        players.Add(newPlayer);
    }

    public void disablePlayer(GameObject player)
    {
        Debug.Log("Disabled Player");
        player.GetComponent<PointAndShoot>().enabled = false;
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<PlayerJump>().enabled = false;
    }

    public GameObject GetActivePlayer()
    {
        GameObject player = players[currentPlayer];
        return player;
    }
}
