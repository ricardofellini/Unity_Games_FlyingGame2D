using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{


    // Author - Ricardo José Fellini
    // 2D Flying 1.0


    // Open the game scene

    public void LoadLevel()
    {


        SceneManager.LoadScene("game");
    }
    
}
