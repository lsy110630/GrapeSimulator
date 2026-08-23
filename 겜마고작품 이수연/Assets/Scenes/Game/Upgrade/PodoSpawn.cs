using UnityEngine;

public class PodoSpawn : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    GameObject btn1;
    GameObject btn2;

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("PodoSpawnT");
        this.tooltip.SetActive(false);

        this.btn1 = GameObject.Find("GPIncrease");
        this.btn1.SetActive(false);
        this.btn2 = GameObject.Find("DPIncrease");
        this.btn2.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().pSPUN >= 5)
        {
            this.maxIncrease = true;
        }

        // 업그레이드가 되있으면 버튼을 보이게한다
        if (this.uDirector.GetComponent<UpgradeDirector>().pSPUN >= 1)
        {
            this.btn1.SetActive(true);
            this.btn2.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().juice >= 15)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().pSPUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().juice -= 15;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().pSP += 1;       // 포도생성확률을 가져와 늘린다

                PlayerPrefs.SetInt("juice", this.uDirector.GetComponent<UpgradeDirector>().juice);
                PlayerPrefs.SetInt("pSP", this.uDirector.GetComponent<UpgradeDirector>().pSP);
                PlayerPrefs.SetInt("pSPUN", this.uDirector.GetComponent<UpgradeDirector>().pSPUN);
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
