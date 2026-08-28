using UnityEngine;
using UnityEngine.SceneManagement;

public class ASceneSwitch : MonoBehaviour
{
    public void Upgrade()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Upgrade");
    }

    public void Mastery()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Artifact()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Artifact");
    }
}