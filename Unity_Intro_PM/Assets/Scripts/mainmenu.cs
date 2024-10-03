using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public string level1Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Playgame()
    {
        SceneManager.LoadScene(level1Scene);
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
