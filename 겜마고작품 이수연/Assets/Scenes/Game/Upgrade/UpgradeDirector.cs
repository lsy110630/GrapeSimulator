using TMPro;
using UnityEngine;

public class UpgradeDirector : MonoBehaviour
{
    GameObject j;
    GameObject tk;             
    GameObject gnUN;              // 포도개수 업그레이드 넘버 텍스트
    GameObject tnUN;              // 시간증가 업그레이드 넘버 텍스트
    GameObject pspnUN;            // 포도스폰 확률 업그레이드 넘버 텍스트
    GameObject bpnUN;             // 부숴짐 업그레이드 넘버 텍스트
    GameObject exnUN;             // 추가 경험치 업그레이드 넘버 텍스트
    GameObject vnUN;              // 포도 가치 업그레이드 넘버 텍스트
    GameObject gpnUN;             // 골드 포도 확률 업그레이드 넘버 텍스트
    GameObject dpnUN;             // 다이아 포도 확률 업그레이드 넘버 텍스트

    // 필요 데이터
    public int podo = 0;
    public int juice = 0;
    public int token = 0;
    public int podoCount = 30;        // 포도개수
    public int gUN = 0;               // 포도개수 증가 업그레이드 넘버
    public int time = 15;             // 시간증가
    public int tUN = 0;               // 시간 증가 업그레이드 넘버
    public int pSP = 0;               // 포도 스폰확률
    public int pSPUN = 0;             // 포도 스폰확률 업그레이드 넘버
    public int bP = 0;                // 부숴질 확률
    public int bPUN = 0;              // 부숴질 확률 업그레이드 넘버
    public int addEX = 0;             // 추가 경험치
    public int EXUN = 0;              // 추가 경험치 업그레이드 넘버
    public int value = 1;             // 포도 가치
    public int vUN = 0;               // 포도 가치 업그레이드 넘버

    public int goldP = 10;            // 골드 포도 확률
    public int gpUN = 0;              // 골드 포도 확률 업그레이드 넘버
    public int diamondP = 5;          // 다이아 포도 확률
    public int dpUN = 0;              // 다이아 포도 확률 업그레이드 넘버

    public int artiP = 1;             // 아티팩트 스폰 확률

    public float speed = 0.03f;       // 속도

    // 아티팩트
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
        this.gnUN = GameObject.Find("GUN");
        this.tnUN = GameObject.Find("TUN");
        this.pspnUN = GameObject.Find("pspnUN");
        this.bpnUN = GameObject.Find("bPUN");
        this.exnUN = GameObject.Find("exnUN");
        this.vnUN = GameObject.Find("VUN");
        this.gpnUN = GameObject.Find("GPUN");
        this.dpnUN = GameObject.Find("DPUN");

        // 필수 데이터 불러오기
        this.podo = PlayerPrefs.GetInt("podo", 0);
        this.juice = PlayerPrefs.GetInt("juice", 0);
        this.token = PlayerPrefs.GetInt("token", 0);
        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);
        this.gUN = PlayerPrefs.GetInt("gUN", 0);
        this.time = PlayerPrefs.GetInt("time", 15);
        this.tUN = PlayerPrefs.GetInt("tUN", 0);
        this.pSP = PlayerPrefs.GetInt("pSP", 0);
        this.pSPUN = PlayerPrefs.GetInt("pSPUN", 0);
        this.bP = PlayerPrefs.GetInt("bP", 0);
        this.bPUN = PlayerPrefs.GetInt("bPUN", 0);
        this.addEX = PlayerPrefs.GetInt("addEX", 0);
        this.EXUN = PlayerPrefs.GetInt("EXUN", 0);
        this.value = PlayerPrefs.GetInt("value", 1);
        this.vUN = PlayerPrefs.GetInt("vUN", 0);

        this.goldP = PlayerPrefs.GetInt("goldP", 10);
        this.gpUN = PlayerPrefs.GetInt("gpUN", 0);
        this.diamondP = PlayerPrefs.GetInt("diamondP", 5);
        this.dpUN = PlayerPrefs.GetInt("dpUN", 0);


        this.artiP = PlayerPrefs.GetInt("artiP", 1);

        this.speed = PlayerPrefs.GetFloat("speed", 0.03f);

        PlayerPrefs.GetInt("artiP", 1);

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
        this.gnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gUN.ToString() + " /" + " 5";
        this.tnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().tUN.ToString() + " /" + " 5";
        this.pspnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().pSPUN.ToString() + " /" + " 5";
        this.bpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().bPUN.ToString() + " /" + " 5";
        this.exnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().EXUN.ToString() + " /" + " 5";
        this.vnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().vUN.ToString() + " /" + " 5";
        this.gpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gpUN.ToString() + " /" + " 5";
        this.dpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().dpUN.ToString() + " /" + " 5";
    }
}
