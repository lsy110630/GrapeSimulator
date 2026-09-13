using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    GameObject btn;

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("EndT");
        this.tooltip.SetActive(false);

        // 이 버튼을 숨긴다
        this.btn = GameObject.Find("End");
        this.btn.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().EndUN >= 1)
        {
            this.maxIncrease = true;
        }

        // 모든 조건이 충족하면 나온다
        if (this.uDirector.GetComponent<UpgradeDirector>().gUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().tUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().pSPUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().bPUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().EXUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().vUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().addGPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().addDPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().gpUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().dpUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().sUN >= 5 && this.uDirector.GetComponent<UpgradeDirector>().spUN >= 5)
        {
            this.btn.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 300 && this.uDirector.GetComponent<UpgradeDirector>().goldjucie >= 125 && this.uDirector.GetComponent<UpgradeDirector>().diamondjucie >= 100)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().spUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 300;     // juice를 가져와 줄인다
                this.uDirector.GetComponent<UpgradeDirector>().goldjucie -= 125;     // goldjuice를 가져와 줄인다
                this.uDirector.GetComponent<UpgradeDirector>().diamondjucie -= 100;     // diamondjuice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().EndUN += 1;

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetInt("goldjucie", this.uDirector.GetComponent<UpgradeDirector>().goldjucie);
                PlayerPrefs.SetInt("diamondjucie", this.uDirector.GetComponent<UpgradeDirector>().diamondjucie);
                PlayerPrefs.SetInt("EndUN", this.uDirector.GetComponent<UpgradeDirector>().EndUN);
                PlayerPrefs.Save();
            }
        }
    }

    public void ShowTooltip()
    {
        this.tooltip.SetActive(true);
    }

    public void HideTooltip()
    {
        this.tooltip.SetActive(false);
    }

    public void Ending()
    {
        if (this.uDirector.GetComponent<UpgradeDirector>().EndUN >= 1)
        {
            // 필수 데이터 저장
            PlayerPrefs.SetInt("podo", this.uDirector.GetComponent<UpgradeDirector>().podo);
            PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);                   // 주스 개수
            PlayerPrefs.SetInt("goldjucie", this.uDirector.GetComponent<UpgradeDirector>().goldjucie);           // 골드 주스 개수
            PlayerPrefs.SetInt("diamondjucie", this.uDirector.GetComponent<UpgradeDirector>().diamondjucie);     // 다이아 주스 개수
            PlayerPrefs.SetInt("token", this.uDirector.GetComponent<UpgradeDirector>().token);                   // 토큰 개수
            PlayerPrefs.SetInt("podoCount", this.uDirector.GetComponent<UpgradeDirector>().podoCount);           // 생성 포도 개수
            PlayerPrefs.SetFloat("time", this.uDirector.GetComponent<UpgradeDirector>().time);                   // 겜 시간
            PlayerPrefs.SetInt("value", this.uDirector.GetComponent<UpgradeDirector>().value);                   // 포도 가치
            PlayerPrefs.SetInt("goldP", this.uDirector.GetComponent<UpgradeDirector>().goldP);                   // 골드 포도 생성될 확률
            PlayerPrefs.SetInt("diamondP", this.uDirector.GetComponent<UpgradeDirector>().diamondP);             // 다이아 포도 생성될 확률
            PlayerPrefs.SetInt("pSP", this.uDirector.GetComponent<UpgradeDirector>().pSP);                       // 포도를 먹었을때 포도가 생성될 확률
            PlayerPrefs.SetInt("bP", this.uDirector.GetComponent<UpgradeDirector>().bP);                         // 포도가 바로 먹어질 확률

            PlayerPrefs.SetInt("addEX", this.uDirector.GetComponent<UpgradeDirector>().addEX);                   // 추가로 얻을 경첨치

            PlayerPrefs.SetFloat("speed", this.uDirector.GetComponent<UpgradeDirector>().speed);                 // 캐릭터 속도
            PlayerPrefs.SetFloat("span", this.uDirector.GetComponent<UpgradeDirector>().span);                   // 포도 획득 속도

            PlayerPrefs.SetInt("badP", this.uDirector.GetComponent<UpgradeDirector>().badP);                     // 안 좋은 이벤트 발생확률
            PlayerPrefs.SetInt("goodP", this.uDirector.GetComponent<UpgradeDirector>().goodP);                     // 좋은 이벤트 발생확률

            PlayerPrefs.SetInt("artiP", this.uDirector.GetComponent<UpgradeDirector>().artiP);                   // 아티팩트 생성 확률

            // 각 업그레이드 상황
            PlayerPrefs.SetInt("gUN", this.uDirector.GetComponent<UpgradeDirector>().gUN);
            PlayerPrefs.SetInt("tUN", this.uDirector.GetComponent<UpgradeDirector>().tUN);
            PlayerPrefs.SetInt("vUN", this.uDirector.GetComponent<UpgradeDirector>().vUN);
            PlayerPrefs.SetInt("addGPUN", this.uDirector.GetComponent<UpgradeDirector>().addGPUN);               // 골드 포도 추가
            PlayerPrefs.SetInt("addDPUN", this.uDirector.GetComponent<UpgradeDirector>().addDPUN);               // 다이아 포도 추가
            PlayerPrefs.SetInt("gpUN", this.uDirector.GetComponent<UpgradeDirector>().gpUN);
            PlayerPrefs.SetInt("dpUN", this.uDirector.GetComponent<UpgradeDirector>().dpUN);
            PlayerPrefs.SetInt("pSPUN", this.uDirector.GetComponent<UpgradeDirector>().pSPUN);
            PlayerPrefs.SetInt("bPUN", this.uDirector.GetComponent<UpgradeDirector>().bPUN);

            PlayerPrefs.SetInt("EXUN", this.uDirector.GetComponent<UpgradeDirector>().EXUN);

            // 아티팩트
            PlayerPrefs.SetInt("shosepodo", this.uDirector.GetComponent<UpgradeDirector>().shosepodo);
            PlayerPrefs.SetInt("scissorspodo", this.uDirector.GetComponent<UpgradeDirector>().scissorspodo);
            PlayerPrefs.SetInt("glovepodo", this.uDirector.GetComponent<UpgradeDirector>().glovepodo);
            PlayerPrefs.SetInt("hatpodo", this.uDirector.GetComponent<UpgradeDirector>().hatpodo);
            PlayerPrefs.SetInt("overallspodo", this.uDirector.GetComponent<UpgradeDirector>().overallspodo);

            PlayerPrefs.Save();
            SceneManager.LoadScene("Ending");
        }
    }
}
