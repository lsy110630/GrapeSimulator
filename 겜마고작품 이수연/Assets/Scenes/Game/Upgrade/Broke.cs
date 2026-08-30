using UnityEngine;

public class Broke : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("BrokeT");
        this.tooltip.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().bPUN >= 5)
        {
            this.maxIncrease = true;
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 15)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().bPUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 15;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().bP += 1;       // 부숴질 확률을 가져와 늘린다

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetInt("bP", this.uDirector.GetComponent<UpgradeDirector>().bP);
                PlayerPrefs.SetInt("bPUN", this.uDirector.GetComponent<UpgradeDirector>().bPUN);
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
