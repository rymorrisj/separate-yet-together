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
            if (players.Count <= 0)
            {
                return;
            }
            isSwitchingCharacter = true;
            GameObject activePlayer = players[currentPlayer];
            disablePlayer(activePlayer);

            if (currentPlayer + 1 == players.Count)
            {
                currentPlayer = 0;
            }
            else
            {
                currentPlayer++;
            }
            activePlayer = players[currentPlayer];
            activePlayer.GetComponent<TheEnabler>().pleaseStart();
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
        player.GetComponent<TheEnabler>().pleaseStop();
    }

    public GameObject GetActivePlayer()
    {
        GameObject player = players[currentPlayer];
        return player;
    }
}
