using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Upgrade");
    }

    public void Quit()
    {
        Application.Quit();
    }
}