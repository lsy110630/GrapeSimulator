using UnityEngine;

public class Artifact : MonoBehaviour
{
    GameObject hats;
    GameObject shoses;
    GameObject scissorses;
    GameObject gloves;
    GameObject overallses;

    GameObject one;
    GameObject two;
    GameObject three;
    GameObject four;
    GameObject five;

    public bool hat = false;
    public bool shose = false;
    public bool scissors = false;
    public bool glove = false;
    public bool overalls = false;

    public int hatpodo = 0;
    public int shosepodo = 0;
    public int scissorspodo = 0;
    public int glovepodo = 0;
    public int overallspodo = 0;

    // 아티팩트가 있는지 없는지 판단, 있으면 플래그 바꾸기
    private void Awake()
    {
        this.hatpodo = PlayerPrefs.GetInt("hatpodo", 0);
        if (hatpodo == 1)
        {
            hat = true;
        }

        this.shosepodo = PlayerPrefs.GetInt("shosepodo", 0);
        if (shosepodo == 1)
        {
            shose = true;
        }

        this.scissorspodo = PlayerPrefs.GetInt("scissorspodo", 0);
        if (scissorspodo == 1)
        {
            scissors = true;
        }

        this.glovepodo = PlayerPrefs.GetInt("glovepodo", 0);
        if (glovepodo == 1)
        {
            glove = true;
        }

        this.overallspodo = PlayerPrefs.GetInt("overallspodo", 0);
        if (overallspodo == 1)
        {
            overalls = true;
        }
    }

    // ?구체, 아티팩트 이미지 찾아놓고 플래그가 켜져있으면 구체 없애고 아티팩트 보이게 바꾸기
    void Start()
    {
        one = GameObject.Find("IDK");
        gloves = GameObject.Find("glove");
        gloves.gameObject.SetActive(false);

        if (glove == true)
        {
            gloves.gameObject.SetActive(true);
            one.gameObject.SetActive(false);
        }

        two = GameObject.Find("IDK1");
        scissorses = GameObject.Find("scissors");
        scissorses.gameObject.SetActive(false);

        if (scissors == true)
        {
            scissorses.gameObject.SetActive(true);
            two.gameObject.SetActive(false);
        }

        three = GameObject.Find("IDK2");
        hats = GameObject.Find("hat");
        hats.gameObject.SetActive(false);

        if (hat == true)
        {
            hats.gameObject.SetActive(true);
            three.gameObject.SetActive(false);
        }

        four = GameObject.Find("IDK3");
        overallses = GameObject.Find("overalls");
        overallses.gameObject.SetActive(false);

        if (overalls == true)
        {
            overallses.gameObject.SetActive(true);
            four.gameObject.SetActive(false);
        }

        five = GameObject.Find("IDK4");
        shoses = GameObject.Find("shose");
        shoses.gameObject.SetActive(false);

        if (shose == true)
        {
            shoses.gameObject.SetActive(true);
            five.gameObject.SetActive(false);
        }

    }
}
