using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Animator Quit, start;

    public void StartClicked()
    {
        start.SetBool("Pressed", true);
        Debug.Log("Hello World");
        Invoke("OpenScene", 1);
    }

    private void OpenScene()
    {
        Application.LoadLevel("Main Game");
    }

    public void QuitClicked()
    {
        Quit.SetBool("Pressed", true);
    }
}
