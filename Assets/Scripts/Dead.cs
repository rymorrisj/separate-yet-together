using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public void NoHealth()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
