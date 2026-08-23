using TMPro;
using UnityEngine;

public class MasteryDirector : MonoBehaviour
{
    GameObject j;
    GameObject tk;

    public int juice = 0;
    public int token = 0;
    public int podoCount = 30;

    void Awake()
    {
        Application.targetFrameRate = 60;

        this.j = GameObject.Find("J");
        this.tk = GameObject.Find("TK");

        this.juice = PlayerPrefs.GetInt("juice", 0);
        this.token = PlayerPrefs.GetInt("token", 0);
        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);
    }

    void Update()
    {
        this.j.GetComponent<TextMeshProUGUI>().text = juice.ToString();
        this.tk.GetComponent<TextMeshProUGUI>().text = token.ToString();
    }
}
