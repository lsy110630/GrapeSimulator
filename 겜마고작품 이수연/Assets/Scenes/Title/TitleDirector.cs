using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        this.audioManager.PlayBackground();
    }

    public void Play()
    {
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("explanation");
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