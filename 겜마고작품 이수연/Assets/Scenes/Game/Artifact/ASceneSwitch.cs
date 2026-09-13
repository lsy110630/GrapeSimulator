using UnityEngine;
using UnityEngine.SceneManagement;

public class ASceneSwitch : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void Upgrade()
    {
        this.audioManager.PlayButtonClick();
        PlayerPrefs.Save();
        SceneManager.LoadScene("Upgrade");
    }

    public void Mastery()
    {
        this.audioManager.PlayButtonClick();
        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Artifact()
    {
        this.audioManager.PlayButtonClick();
        PlayerPrefs.Save();
        SceneManager.LoadScene("Artifact");
    }
}