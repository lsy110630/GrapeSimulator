using UnityEngine;
using UnityEngine.SceneManagement;

public class MASceneSwitch : MonoBehaviour
{
    GameObject director;

    private void Start()
    {
        director = GameObject.Find("MasteryDirector");
    }

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

    public void Card()
    {
        if(director.GetComponent<MasteryDirector>().token >= 1)
        {
            director.GetComponent<MasteryDirector>().token -= 1;

            SceneManager.LoadScene("Card");
            PlayerPrefs.Save();
        }
    }
}