using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    public void Play()
    {
        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Upgrade");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}