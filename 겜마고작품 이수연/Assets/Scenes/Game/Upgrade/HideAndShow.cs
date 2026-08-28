using UnityEngine;

public class HideAndShow : MonoBehaviour
{
    GameObject udirector;
    GameObject canvas;
    GameObject show;
    GameObject hide;

    void Start()
    {
        this.udirector = GameObject.Find("UpgradeDirector");
        this.canvas = GameObject.Find("Canvas-Etc");
        this.show = GameObject.Find("Show");
        this.hide = GameObject.Find("Hide");
        this.show.SetActive(false);
    }

    public void Show()
    {
        this.canvas.SetActive(true);
        this.show.SetActive(false);
        this.hide.SetActive(true);
    }

    public void Hide()
    {
        this.canvas.SetActive(false);
        this.hide.SetActive(false);
        this.show.SetActive(true);
    }
}
