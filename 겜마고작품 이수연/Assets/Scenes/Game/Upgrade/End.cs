using UnityEngine;

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
        if (this.uDirector.GetComponent<UpgradeDirector>().gUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().tUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().pSPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().bPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().EXUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().vUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().addGPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().addDPUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().gpUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().dpUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().sUN >= 1 && this.uDirector.GetComponent<UpgradeDirector>().spUN >= 1)
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
}
