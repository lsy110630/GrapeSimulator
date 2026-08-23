using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ArtifactDirector : MonoBehaviour
{
    GameObject name;
    GameObject explanation;

    public int hatpodo = 0;         
    public int glovepodo = 0;     
    public int scissorspodo = 0;         
    public int shosepodo = 0;         
    public int overallspodo = 0;      

    void Awake()
    {
        this.hatpodo = PlayerPrefs.GetInt("hatpodo", 0);
        this.shosepodo = PlayerPrefs.GetInt("shosepodo", 0);
        this.scissorspodo = PlayerPrefs.GetInt("scissorspodo", 0);
        this.glovepodo = PlayerPrefs.GetInt("glovepodo", 0);
        this.overallspodo = PlayerPrefs.GetInt("overallspodo", 0);
    }

    private void Start()
    {
        this.name = GameObject.Find("name");
        this.explanation = GameObject.Find("explanation");
    }

    void Update()
    {

    }

    public void glove()
    {
        if (glovepodo == 1)
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "장갑";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "손이 덜 아프다";
        }

        else
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "???";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "???";
        }
    }

    public void scissors()
    {
        if (scissorspodo == 1)
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "가위";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "손으로 따는거 보다 좋다";
        }

        else
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "???";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "???";
        }
    }

    public void hat()
    {
        if (hatpodo == 1)
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "모자";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "태양이 덜 부담스럽다";
        }

        else
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "???";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "???";
        }
    }

    public void overalls()
    {
        if (overallspodo == 1)
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "맬빵바지";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "있어 보인다";
        }

        else
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "???";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "???";
        }
    }

    public void shose()
    {
        if (shosepodo == 1)
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "신발";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "물집이 안 생긴다";
        }

        else
        {
            this.name.GetComponent<TextMeshProUGUI>().text = "???";
            this.explanation.GetComponent<TextMeshProUGUI>().text = "???";
        }
    }
}
