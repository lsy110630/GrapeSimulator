using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplanationDirector : MonoBehaviour
{
    GameObject scene1;
    GameObject scene2;
    GameObject scene3;
    GameObject scene4;

    void Start()
    {
        this.scene1 = GameObject.Find("scene1");

        this.scene2 = GameObject.Find("scene2");
        this.scene2.SetActive(false);

        this.scene3 = GameObject.Find("scene3");
        this.scene3.SetActive(false);

        this.scene4 = GameObject.Find("scene4");
        this.scene4.SetActive(false);
    }

    public void next1()
    {
        this.scene2.SetActive(true);
        this.scene1.SetActive(false);
    }

    public void next2()
    {
        this.scene3.SetActive(true);
        this.scene2.SetActive(false);
    }

    public void next3()
    {
        this.scene4.SetActive(true);
        this.scene3.SetActive(false);
    }

    public void finish()
    {
        SceneManager.LoadScene("MainGame");
    }
}
