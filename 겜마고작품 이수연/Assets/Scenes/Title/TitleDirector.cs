using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Save");
    }

    public void Quit()
    {
        Application.Quit();
    }
}