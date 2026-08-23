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
        SceneManager.LoadScene("Upgrade");
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