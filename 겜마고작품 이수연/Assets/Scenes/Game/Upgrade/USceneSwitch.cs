using UnityEngine;
using UnityEngine.SceneManagement;

public class USceneSwitch : MonoBehaviour
{
    GameObject uDirector;

    private void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
    }

    public void Upgrade()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Upgrade");
    }

    public void Mastery()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Artifact()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Artifact");
    }

    public void MPlay()
    {
        // 필수 데이터 저장
        PlayerPrefs.SetInt("podo", this.uDirector.GetComponent<UpgradeDirector>().podo);
        PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);                   // 주스 개수
        PlayerPrefs.SetInt("goldjucie", this.uDirector.GetComponent<UpgradeDirector>().goldjucie);           // 골드 주스 개수
        PlayerPrefs.SetInt("diamondjucie", this.uDirector.GetComponent<UpgradeDirector>().diamondjucie);     // 다이아 주스 개수
        PlayerPrefs.SetInt("token", this.uDirector.GetComponent<UpgradeDirector>().token);                   // 토큰 개수
        PlayerPrefs.SetInt("podoCount", this.uDirector.GetComponent<UpgradeDirector>().podoCount);           // 생성 포도 개수
        PlayerPrefs.SetInt("time", this.uDirector.GetComponent<UpgradeDirector>().time);                     // 겜 시간
        PlayerPrefs.SetInt("value", this.uDirector.GetComponent<UpgradeDirector>().value);                   // 포도 가치
        PlayerPrefs.SetInt("goldP", this.uDirector.GetComponent<UpgradeDirector>().goldP);                   // 골드 포도 생성될 확률
        PlayerPrefs.SetInt("diamondP", this.uDirector.GetComponent<UpgradeDirector>().diamondP);             // 다이아 포도 생성될 확률
        PlayerPrefs.SetInt("pSP", this.uDirector.GetComponent<UpgradeDirector>().pSP);                       // 포도를 먹었을때 포도가 생성될 확률
        PlayerPrefs.SetInt("bP", this.uDirector.GetComponent<UpgradeDirector>().bP);                         // 포도가 바로 먹어질 확률

        PlayerPrefs.SetInt("addEX", this.uDirector.GetComponent<UpgradeDirector>().addEX);                   // 추가로 얻을 경첨치

        PlayerPrefs.SetFloat("speed", this.uDirector.GetComponent<UpgradeDirector>().speed);                 // 캐릭터 속도

        PlayerPrefs.SetInt("artiP", this.uDirector.GetComponent<UpgradeDirector>().artiP);                   // 아티팩트 생성 확률

        // 각 업그레이드 상황
        PlayerPrefs.SetInt("gUN", this.uDirector.GetComponent<UpgradeDirector>().gUN);
        PlayerPrefs.SetInt("gUNG", this.uDirector.GetComponent<UpgradeDirector>().gUNG);
        PlayerPrefs.SetInt("gUND", this.uDirector.GetComponent<UpgradeDirector>().gUND);
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

        SceneManager.LoadScene("MainGame");
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("podo", 0);
        PlayerPrefs.SetInt("jucie", 0);
        PlayerPrefs.SetInt("goldjucie", 0);
        PlayerPrefs.SetInt("diamondjucie", 0);
        PlayerPrefs.SetInt("podoCount", 30);
        PlayerPrefs.SetInt("gUN", 0);
        PlayerPrefs.SetInt("gUNG", 0);
        PlayerPrefs.SetInt("gUND", 0);
        PlayerPrefs.SetInt("time", 15);
        PlayerPrefs.SetInt("tUN", 0);
        PlayerPrefs.SetInt("value", 1);
        PlayerPrefs.SetInt("vUN", 0);
        PlayerPrefs.SetInt("addGPUN", 0);
        PlayerPrefs.SetInt("addDPUN", 0);
        PlayerPrefs.SetInt("goldP", 0);
        PlayerPrefs.SetInt("gpUN", 0);
        PlayerPrefs.SetInt("diamondP", 0);
        PlayerPrefs.SetInt("dpUN", 0);

        PlayerPrefs.SetInt("pSP", 0);
        PlayerPrefs.SetInt("pSPUN", 0);
        PlayerPrefs.SetInt("bP", 0);
        PlayerPrefs.SetInt("bPUN", 0);

        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetInt("token", 0);
        PlayerPrefs.SetInt("EX", 0);
        PlayerPrefs.SetInt("maxEX", 50);

        PlayerPrefs.SetInt("addEX", 0);
        PlayerPrefs.SetInt("EXUN", 0);

        PlayerPrefs.SetFloat("speed", 0.03f);
        PlayerPrefs.SetInt("sUN", 0);

        PlayerPrefs.SetInt("artiP", 1);

        PlayerPrefs.SetInt("shosepodo", 0);
        PlayerPrefs.SetInt("scissorspodo", 0);
        PlayerPrefs.SetInt("glovepodo", 0);
        PlayerPrefs.SetInt("hatpodo", 0);
        PlayerPrefs.SetInt("overallspodo", 0);

        PlayerPrefs.Save();

        SceneManager.LoadScene("Upgrade");
    }
}