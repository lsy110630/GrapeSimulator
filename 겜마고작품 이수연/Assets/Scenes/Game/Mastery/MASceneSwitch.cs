using UnityEngine;
using UnityEngine.SceneManagement;

public class MASceneSwitch : MonoBehaviour
{
    GameObject director;
    AudioManager audioManager;

    private void Start()
    {
        director = GameObject.Find("MasteryDirector");
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

    public void Card()
    {
        if(director.GetComponent<MasteryDirector>().token >= 1)
        {
            this.director.GetComponent<MasteryDirector>().token -= 1;
            PlayerPrefs.SetInt("token", this.director.GetComponent<MasteryDirector>().token);

            this.audioManager.PlayButtonClick();
            PlayerPrefs.Save();
            SceneManager.LoadScene("Card");
        }
    }
}