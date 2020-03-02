using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>Contains event handlers for the main menu.</summary>
public class MainMenu : MonoBehaviour
{
    public void PlayMaze() {
        SceneManager.LoadScene("maze");
    }
}
