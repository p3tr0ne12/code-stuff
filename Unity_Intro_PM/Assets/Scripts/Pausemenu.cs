using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    
    public void Quitgame()
    {
        SceneManager.LoadScene(mainScene);
    }
}
