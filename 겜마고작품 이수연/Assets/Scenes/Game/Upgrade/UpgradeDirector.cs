using TMPro;
using UnityEngine;

public class UpgradeDirector : MonoBehaviour
{
    GameObject j;
    GameObject gj;                // 골드 주스
    GameObject dj;                // 다이아 주스
    GameObject tk;             
    GameObject gnUN;              // 포도개수 업그레이드 넘버 텍스트
    GameObject gnUNG;             // 골드 쪽 포도개수 업그레이드 넘버 텍스트
    GameObject gnUND;             // 다이아 쪽 포도개수 업그레이드 넘버 텍스트
    GameObject tnUN;              // 시간증가 업그레이드 넘버 텍스트
    GameObject pspnUN;            // 포도스폰 확률 업그레이드 넘버 텍스트
    GameObject bpnUN;             // 부숴짐 업그레이드 넘버 텍스트
    GameObject exnUN;             // 추가 경험치 업그레이드 넘버 텍스트
    GameObject vnUN;              // 포도 가치 업그레이드 넘버 텍스트
    GameObject gpnUN;             // 골드 포도 확률 업그레이드 넘버 텍스트
    GameObject GPpay;
    GameObject dpnUN;             // 다이아 포도 확률 업그레이드 넘버 텍스트
    GameObject DPpay;
    GameObject snUN;              // 속도 업그레이드 넘버 텍스트
    GameObject addDPnUN;          // 골드 포도 추가 업그레이드 넘버 텍스트
    GameObject addGPnUN;          // 다이아 포도 추가 업그레이드 넘버 텍스트

    // 필요 데이터
    public int podo = 0;              // 그냥 포도
    public int goldpodo = 0;          // 골드 포도
    public int diamondpodo = 0;       // 다이아 포도
    public int jucie = 0;             // 그냥 주스
    public int goldjucie = 0;         // 골드 주스
    public int diamondjucie = 0;      // 다이아 주스
    public int token = 0;
    public int podoCount = 30;        // 포도개수

    public int gUN = 0;               // 포도개수 증가 업그레이드 넘버
    public int gUNG = 0;              // 골드 쪽 포도개수 증가 업그레이드 넘버
    public int gUND = 0;              // 다이아 쪽 포도개수 증가 업그레이드 넘버

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
    public int addGPUN = 0;           // 골드 포도 추가
    public int addDPUN = 0;           // 다이아 포도 추가
    public int goldP = 0;             // 골드 포도 확률
    public int gpUN = 0;              // 골드 포도 확률 업그레이드 넘버
    public int diamondP = 0;          // 다이아 포도 확률
    public int dpUN = 0;              // 다이아 포도 확률 업그레이드 넘버

    public int artiP = 1;             // 아티팩트 스폰 확률

    public float speed = 0.03f;       // 속도
    public int sUN = 0;               // 속도 업그레이드 넘버

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
        this.gj = GameObject.Find("GJ");
        this.dj = GameObject.Find("DJ");
        this.tk = GameObject.Find("TK");
        this.gnUN = GameObject.Find("GUNG");
        this.gnUNG = GameObject.Find("GUND");
        this.gnUND = GameObject.Find("GUN");
        this.tnUN = GameObject.Find("TUN");
        this.pspnUN = GameObject.Find("pspnUN");
        this.bpnUN = GameObject.Find("bPUN");
        this.exnUN = GameObject.Find("exnUN");
        this.vnUN = GameObject.Find("VUN");
        this.addGPnUN = GameObject.Find("addGPUN");
        this.addDPnUN = GameObject.Find("addDPUN");
        this.gpnUN = GameObject.Find("GPUN");
        this.GPpay = GameObject.Find("GPpay");
        this.dpnUN = GameObject.Find("DPUN");
        this.DPpay = GameObject.Find("DPpay");
        this.snUN = GameObject.Find("SUN");

        // 필수 데이터 불러오기
        this.podo = PlayerPrefs.GetInt("podo", 0);
        this.jucie = PlayerPrefs.GetInt("jucie", 0);
        this.goldjucie = PlayerPrefs.GetInt("goldjucie", 0);
        this.diamondjucie = PlayerPrefs.GetInt("diamondjucie", 0);
        this.token = PlayerPrefs.GetInt("token", 0);
        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);
        this.gUN = PlayerPrefs.GetInt("gUN", 0);
        this.gUNG = PlayerPrefs.GetInt("gUNG", 0);
        this.gUND = PlayerPrefs.GetInt("gUND", 0);
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
        this.addGPUN = PlayerPrefs.GetInt("addGPUN", 0);
        this.addDPUN = PlayerPrefs.GetInt("addDPUN", 0);
        this.goldP = PlayerPrefs.GetInt("goldP", 0);
        this.gpUN = PlayerPrefs.GetInt("gpUN", 0);
        this.diamondP = PlayerPrefs.GetInt("diamondP", 0);
        this.dpUN = PlayerPrefs.GetInt("dpUN", 0);


        this.artiP = PlayerPrefs.GetInt("artiP", 1);

        this.speed = PlayerPrefs.GetFloat("speed", 0.03f);
        this.sUN = PlayerPrefs.GetInt("sUN", 0);

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
        this.j.GetComponent<TextMeshProUGUI>().text = jucie.ToString();
        this.gj.GetComponent<TextMeshProUGUI>().text = goldjucie.ToString();
        this.dj.GetComponent<TextMeshProUGUI>().text = diamondjucie.ToString();
        this.tk.GetComponent<TextMeshProUGUI>().text = token.ToString();
        this.gnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gUN.ToString() + " /" + " 5";
        this.gnUNG.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gUNG.ToString() + " /" + " 5";
        this.gnUND.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gUND.ToString() + " /" + " 5";
        this.tnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().tUN.ToString() + " /" + " 5";
        this.pspnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().pSPUN.ToString() + " /" + " 5";
        this.bpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().bPUN.ToString() + " /" + " 5";
        this.exnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().EXUN.ToString() + " /" + " 5";
        this.vnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().vUN.ToString() + " /" + " 5";
        this.addGPnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().addGPUN.ToString() + " /" + " 1";
        this.addDPnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().addDPUN.ToString() + " /" + " 1";
        this.gpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().gpUN.ToString() + " /" + " 5";

        this.GPpay.GetComponent<TextMeshProUGUI>().text = "골드포도주스 " + this.GetComponent<GPIncrease>().pay.ToString() + "개";
        
        this.dpnUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().dpUN.ToString() + " /" + " 5";

        this.DPpay.GetComponent<TextMeshProUGUI>().text = "다이아포도주스 " + this.GetComponent<DPIncrease>().pay.ToString() + "개";

        this.snUN.GetComponent<TextMeshProUGUI>().text = this.GetComponent<UpgradeDirector>().sUN.ToString() + " /" + " 5";
    }
}
