using UnityEngine;

public class GPSpawn : MonoBehaviour
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
        this.tooltip = GameObject.Find("GPSpawnT");
        this.tooltip.SetActive(false);

        this.btn1 = GameObject.Find("GPIncrease");
        this.btn1.SetActive(false);

    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().addGPUN >= 1)
        {
            this.maxIncrease = true;
            this.btn1.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 30)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().addGPUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 30;         // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().goldP += 10;          // 골드포도 생성확률을 가져와 늘린다

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetInt("goldP", this.uDirector.GetComponent<UpgradeDirector>().goldP);
                PlayerPrefs.SetInt("addGPUN", this.uDirector.GetComponent<UpgradeDirector>().addGPUN);
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
