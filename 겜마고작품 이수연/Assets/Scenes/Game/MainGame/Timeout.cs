using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour
{
    GameObject clock;
    public float time = 15f;
    GameObject mDirector;

    void Start()
    {
        this.clock = GameObject.Find("Time");
        this.mDirector = GameObject.Find("MainDirector");
        this.time = PlayerPrefs.GetInt("time", 15);
    }

    void Update()
    {
        this.clock.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        if (time <= 0)
        {
            // 데이터 저장
            PlayerPrefs.SetInt("podo", this.mDirector.GetComponent<MainGameDirector>().podo);

            // 주스 데이터 불러와서 누적
            int juice = PlayerPrefs.GetInt("juice", 0); // 원래 주스 개수
            juice += this.mDirector.GetComponent<MainGameDirector>().podo / 3; // 포도 / 3 만큼 추가
            PlayerPrefs.SetInt("juice", juice); // 저장

            PlayerPrefs.SetInt("token", this.mDirector.GetComponent<MainGameDirector>().token);

            // 생성되는 포도 개수 저장
            PlayerPrefs.SetInt("podoCount", this.mDirector.GetComponent<MainGameDirector>().podoCount);

            // 포도 가치
            PlayerPrefs.SetInt("value", this.mDirector.GetComponent<MainGameDirector>().value);

            // 골드, 다이아 포도 생성 확률
            PlayerPrefs.SetInt("goldP", this.mDirector.GetComponent<MainGameDirector>().goldP);
            PlayerPrefs.SetInt("diamondP", this.mDirector.GetComponent<MainGameDirector>().diamondP);

            // 겜 시간
            int time = PlayerPrefs.GetInt("time", 15);
            PlayerPrefs.SetInt("time", time);

            // 캐릭터 속도
            PlayerPrefs.SetFloat("speed", this.mDirector.GetComponent<MainGameDirector>().speed);

            // 포도를 먹었을때 포도가 새로 생성될 확률
            PlayerPrefs.SetInt("pSP", this.mDirector.GetComponent<MainGameDirector>().pSP);

            // 포도가 바로 먹어질 확률
            PlayerPrefs.SetInt("bP", this.mDirector.GetComponent<MainGameDirector>().bP);

            // 아티팩트 포도가 생성될 확률
            PlayerPrefs.SetInt("artiP", this.mDirector.GetComponent<MainGameDirector>().artiP);

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

            // 포도를 먹었을때 추가로 얻을 경험치 변수
            PlayerPrefs.SetInt("addEX", this.mDirector.GetComponent<MainGameDirector>().addEX);

            PlayerPrefs.Save();

            SceneManager.LoadScene("Upgrade");
        }
        else
        {
            time -= 0.01f;
        }
    }
}
