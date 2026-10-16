using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour
{
    GameObject clock;
    public float time = 15f;
    public int badP = 0;                // 안 좋은 이벤트 확률
    public int goodP = 0;               // 좋은 이벤트 확률
    GameObject player;
    GameObject mDirector;
    GameObject bad;
    GameObject good;

    float span = 3.0f;          // 이벤트 주기
    float span2 = 1.0f;         // 이벤트가 알림화면 시간
    float span3 = 2.0f;         // 플레이어속도용
    float delta = 0;            // 시간재기  - 이벤트 발생요
    float delta2 = 0;           // 시간재기2 - 이벤트 표시용
    float delta3 = 0;           // 시간재기3 - 플레이어 속도용
    bool goodEvent = false;     // 이벤트 발생했냐 안했냐
    bool badEvent = false;      // 이벤트 발생했냐 안했냐
    bool playerBad = false;
    bool playerGood = false;
    float originalSpeed = 0f;

    private void Awake()
    {
        this.bad = GameObject.Find("bad");
        this.good = GameObject.Find("good");
    }

    void Start()
    {
        this.clock = GameObject.Find("Time");
        this.player = GameObject.Find("Player");
        this.mDirector = GameObject.Find("MainDirector");
        this.time = PlayerPrefs.GetFloat("time", 15f);
        this.badP = PlayerPrefs.GetInt("badP", 0);
        this.goodP = PlayerPrefs.GetInt("goodP", 0);
    }

    void Update()
    {
        this.clock.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        // 시간이 다 되면
        if (time <= 0)
        {
            // 데이터 저장
            PlayerPrefs.SetInt("podo", this.mDirector.GetComponent<MainGameDirector>().podo);

            // 주스 데이터 불러와서 누적
            int jucie = PlayerPrefs.GetInt("jucie", 0); // 원래 주스 개수
            jucie += this.mDirector.GetComponent<MainGameDirector>().podo / 3; // 포도 / 3 만큼 추가
            PlayerPrefs.SetInt("jucie", jucie); // 저장

            // 골드 주스 데이터 불러와서 누적
            int goldjucie = PlayerPrefs.GetInt("goldjucie", 0); // 원래 골드 주스 개수
            goldjucie += this.mDirector.GetComponent<MainGameDirector>().goldpodo / 3; // 포도 / 3 만큼 추가
            PlayerPrefs.SetInt("goldjucie", goldjucie); // 저장

            // 다이아 주스 데이터 불러와서 누적
            int diamondjucie = PlayerPrefs.GetInt("diamondjucie", 0); // 원래 다이아 주스 개수
            diamondjucie += this.mDirector.GetComponent<MainGameDirector>().diamondpodo / 3; // 포도 / 3 만큼 추가
            PlayerPrefs.SetInt("diamondjucie", diamondjucie); // 저장

            // 토큰 저장
            PlayerPrefs.SetInt("token", this.mDirector.GetComponent<MainGameDirector>().token);

            // 아티팩트가 있는지 없는지 판단할 변수
            PlayerPrefs.SetInt("shosepodo", this.mDirector.GetComponent<MainGameDirector>().shosepodo);
            PlayerPrefs.SetInt("scissorspodo", this.mDirector.GetComponent<MainGameDirector>().scissorspodo);
            PlayerPrefs.SetInt("glovepodo", this.mDirector.GetComponent<MainGameDirector>().glovepodo);
            PlayerPrefs.SetInt("hatpodo", this.mDirector.GetComponent<MainGameDirector>().hatpodo);
            PlayerPrefs.SetInt("overallspodo", this.mDirector.GetComponent<MainGameDirector>().overallspodo);

            // 레벨, 현재 경험치, 최대 경험치 변수
            PlayerPrefs.SetInt("level", this.mDirector.GetComponent<MainGameDirector>().level);
            PlayerPrefs.SetInt("EX", this.mDirector.GetComponent<MainGameDirector>().EX);
            PlayerPrefs.SetInt("maxEX", this.mDirector.GetComponent<MainGameDirector>().maxEX);

            PlayerPrefs.SetInt("pSP", this.mDirector.GetComponent<MainGameDirector>().pSP);                       // 포도를 먹었을때 포도가 생성될 확률
            PlayerPrefs.SetInt("bP", this.mDirector.GetComponent<MainGameDirector>().bP);                         // 포도가 바로 먹어질 확률
            PlayerPrefs.SetFloat("span", this.mDirector.GetComponent<MainGameDirector>().span);                   // 포도 획득 속도
            // 포도를 먹었을때 추가로 얻을 경험치 변수
            PlayerPrefs.SetInt("addEX", this.mDirector.GetComponent<MainGameDirector>().addEX);

            PlayerPrefs.Save();

            SceneManager.LoadScene("Upgrade");
        }
        else
        {
            time -= 0.0167f; // 프레임을 60으로 제한해놓은거에 시간 줄어드는걸 맞춤
        }

        delta += Time.deltaTime;
        // 주기가 돌면
        if (delta > span)
        {
            int dice1 = Random.Range(1, 101);
            // 주사위가 총 이벤트 확률보다 작으면
            if (dice1 <= badP + goodP)
            {
                int dice2 = Random.Range(1, badP + goodP + 1);

                // 주사위가 안 좋은 이벤트에 걸리면
                if (dice2 <= badP)
                {
                    this.bad.SetActive(true);
                    this.badEvent = true; // 이벤트 발생
                    this.playerBad = true;

                    originalSpeed = this.player.GetComponent<PlayerController>().speed;
                    this.player.GetComponent<PlayerController>().speed = 0.01f;
                }
                else // good
                {
                    this.good.SetActive(true);
                    this.goodEvent = true; // 이벤트 발생
                    this.playerGood = true;

                    originalSpeed = this.player.GetComponent<PlayerController>().speed;
                    this.player.GetComponent<PlayerController>().speed *= 1.5f;
                }
            }

            delta = 0;
        }

        // 이벤트 뜨면 이벤트용 시간계산
        if (this.badEvent)
        {
            delta2 += Time.deltaTime;
            // 일정 시간동안 나왔다 지우기
            if (delta2 > span2)
            {
                this.bad.SetActive(false);
                delta2 = 0;
                this.badEvent = false;
            }
        }
        if (this.goodEvent)
        {
            delta2 += Time.deltaTime;
            // 일정 시간동안 나왔다 지우기
            if (delta2 > span2)
            {
                this.good.SetActive(false);
                delta2 = 0;
                this.goodEvent = false;
            }
        }

        // 플레이어 속도변환용
        if (this.playerBad)
        {
            delta3 += Time.deltaTime;
            if (delta3 > span3)
            {
                delta3 = 0;
                this.playerBad = false;
                this.player.GetComponent<PlayerController>().speed = this.originalSpeed;
            }
        }
        if (this.playerGood)
        {
            delta3 += Time.deltaTime;
            if (delta3 > span3)
            {
                delta3 = 0;
                this.playerGood = false;
                this.player.GetComponent<PlayerController>().speed = this.originalSpeed;
            }
        }
    }
}
