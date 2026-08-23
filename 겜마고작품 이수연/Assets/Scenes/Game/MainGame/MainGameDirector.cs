using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameDirector : MonoBehaviour
{
    GameObject Circle;                  // 먹는 범위 원

    GameObject grape;                   // 먹은 포도 개수 텍스트
    GameObject levelT;                  // 레벨텍스트
    GameObject EXT;                     // 경험치 텍스트
    GameObject maxEXT;                  // 최대경험치 텍스트

    public int podo = 0;
    public int podoCount = 30;          // 포도 개수
    public int value = 1;               // 포도 가치
    public int goldP = 10;              // 골드 포도 확률
    public int diamondP = 5;            // 다이아 포도 확률
    public int pSP = 0;                 // 포도생성 확률
    public int bP = 0;                  // 부숴짐 확률
    public int artiP = 1;               // 아티팩트 스폰 확률

    public float speed = 0.03f;         // 속도

    // 아티팩트 있는지 없는지
    public int hatpodo = 0;
    public int glovepodo = 0;
    public int scissorspodo = 0;
    public int shosepodo = 0;
    public int overallspodo = 0;

    public int EX = 0;                  // 경험치
    public int maxEX = 50;              // 레벨업 필요경험치
    public int level = 0;               // 레벨
    public int token = 0;               // 레벨업 토큰
    public int addEX = 0;               // 추가 경험치(업그레이드)

    private void Awake()
    {
        this.Circle = GameObject.Find("Circle");

        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);
        this.value = PlayerPrefs.GetInt("value", 1);
        this.goldP = PlayerPrefs.GetInt("goldP", 10);
        this.diamondP = PlayerPrefs.GetInt("diamondP", 5);
        this.speed = PlayerPrefs.GetFloat("speed", 0.03f);
        this.pSP = PlayerPrefs.GetInt("pSP", 0);
        this.bP = PlayerPrefs.GetInt("bP", 0);
        this.artiP = PlayerPrefs.GetInt("artiP", 1);
        this.level = PlayerPrefs.GetInt("level", 0);
        this.EX = PlayerPrefs.GetInt("EX", 0);
        this.maxEX = PlayerPrefs.GetInt("maxEX", 50);
        this.addEX = PlayerPrefs.GetInt("addEX", 0);
        this.token = PlayerPrefs.GetInt("token", 0);

        this.hatpodo = PlayerPrefs.GetInt("hatpodo", 0);
        if (hatpodo == 1)
        {
            speed *= 1.1f;
        }

        this.shosepodo = PlayerPrefs.GetInt("shosepodo", 0);
        if (shosepodo == 1)
        {
            speed *= 1.1f;
        }

        this.scissorspodo = PlayerPrefs.GetInt("scissorspodo", 0);
        if (scissorspodo == 1)
        {
            this.Circle.transform.localScale = new Vector3(1.98f, 1.98f, 1f);
        }

        this.glovepodo = PlayerPrefs.GetInt("glovepodo", 0);
        if (glovepodo == 1)
        {
            bP += 5;
        }

        this.overallspodo = PlayerPrefs.GetInt("overallspodo", 0);
        if (overallspodo == 1)
        {
            speed *= 1.1f;
        }
    }


    void Start()
    {
        Application.targetFrameRate = 60;

        podo = 0;
        this.grape = GameObject.Find("Grape");
        this.levelT = GameObject.Find("levelT");
        this.EXT = GameObject.Find("EXT");
        this.maxEXT = GameObject.Find("maxEXT");
    }

    void Update()
    {
        // podo 변수를 텍스트로 띄우기
        this.grape.GetComponent<TextMeshProUGUI>().text = podo.ToString();
        // 레벨 띄우기
        this.levelT.GetComponent<TextMeshProUGUI>().text = level.ToString();
        // 현재 경험치량 띄우기
        this.EXT.GetComponent<TextMeshProUGUI>().text = EX.ToString();
        // 최대경험치 띄우기
        this.maxEXT.GetComponent<TextMeshProUGUI>().text = maxEX.ToString();
    }

    private void FixedUpdate()
    {
        if (EX >= maxEX)
        {
            level += 1;
            token += 1;

            maxEX *= 2;
            EX = 0;
        }
    }
}