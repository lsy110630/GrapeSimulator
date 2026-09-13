using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDirector : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void Title()
    {
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Title");
    }
}
