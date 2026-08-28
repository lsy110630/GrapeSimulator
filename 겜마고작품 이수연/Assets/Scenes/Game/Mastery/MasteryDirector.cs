using TMPro;
using UnityEngine;

public class MasteryDirector : MonoBehaviour
{
    GameObject j;
    GameObject tk;

    public int juice = 0;
    public int token = 0;
    public int podoCount = 30;

    // 아티팩트 있는지 없는지
    public int hatpodo = 0;
    public int glovepodo = 0;
    public int scissorspodo = 0;
    public int shosepodo = 0;
    public int overallspodo = 0;

    void Awake()
    {
        Application.targetFrameRate = 60;

        this.j = GameObject.Find("J");
        this.tk = GameObject.Find("TK");

        this.juice = PlayerPrefs.GetInt("juice", 0);
        this.token = PlayerPrefs.GetInt("token", 0);
        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);

        // 아티팩트
        this.hatpodo = PlayerPrefs.GetInt("hatpodo", 0);
        this.shosepodo = PlayerPrefs.GetInt("shosepodo", 0);
        this.scissorspodo = PlayerPrefs.GetInt("scissorspodo", 0);
        this.glovepodo = PlayerPrefs.GetInt("glovepodo", 0);
        this.overallspodo = PlayerPrefs.GetInt("overallspodo", 0);
    }

    void Update()
    {
        this.j.GetComponent<TextMeshProUGUI>().text = juice.ToString();
        this.tk.GetComponent<TextMeshProUGUI>().text = token.ToString();
    }
}
