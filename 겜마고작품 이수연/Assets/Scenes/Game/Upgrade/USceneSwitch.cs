using UnityEngine;
using UnityEngine.SceneManagement;

public class USceneSwitch : MonoBehaviour
{
    public void Upgrade()
    {
        SceneManager.LoadScene("Upgrade");
        PlayerPrefs.Save();
    }

    public void Mastery()
    {
        SceneManager.LoadScene("Mastery");
        PlayerPrefs.Save();
    }

    public void Artifact()
    {
        SceneManager.LoadScene("Artifact");
        PlayerPrefs.Save();
    }
}