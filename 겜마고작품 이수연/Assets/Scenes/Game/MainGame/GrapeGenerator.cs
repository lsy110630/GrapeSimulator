using UnityEngine;

public class GrapeGenerator : MonoBehaviour
{
    public int number;                   // 포도개수
    public GameObject grape;             // 포도를 담을 변수
    public GameObject goldgrape;         // 골드 포도
    public GameObject diamondgrape;      // 다이아 포도
    GameObject item;                     // 최종 스폰 옵젝

    // 아티팩트
    public GameObject glovepodo;
    public GameObject scissorspodo;
    public GameObject hatpodo;
    public GameObject overallspodo;
    public GameObject shosepodo;

    GameObject mDirector;

    bool one = true;

    void Start()
    {
        this.mDirector = GameObject.Find("MainDirector");

        // 생성할 포도 개수 불러오기
        this.number = this.mDirector.GetComponent<MainGameDirector>().podoCount;

        // 포도를 30개 소환한다
        for (int i = 0; i < number; i++)
        {
            int dice = Random.Range(1, 1001);    
            int gold = Random.Range(1, 101);      
            int diamond = Random.Range(1, 101);    

            // 아티팩트 소환
            if (dice <= this.mDirector.GetComponent<MainGameDirector>().artiP && one == true) 
            {
                dice = Random.Range(1, 6);

                if(dice == 1 && this.mDirector.GetComponent<MainGameDirector>().glovepodo == 0)
                {
                    item = Instantiate(glovepodo);
                }

                if (dice == 2 && this.mDirector.GetComponent<MainGameDirector>().scissorspodo == 0)
                {
                    item = Instantiate(scissorspodo);
                }

                if (dice == 3 && this.mDirector.GetComponent<MainGameDirector>().hatpodo == 0)
                {
                    item = Instantiate(hatpodo);
                }

                if (dice == 4 && this.mDirector.GetComponent<MainGameDirector>().overallspodo == 0)
                {
                    item = Instantiate(overallspodo);
                }

                if (dice == 5 && this.mDirector.GetComponent<MainGameDirector>().shosepodo == 0)
                {
                    item = Instantiate(shosepodo);
                }

                one = false;
            }

            // 골드 포도 소환
            else if (gold <= this.mDirector.GetComponent<MainGameDirector>().goldP)
            {
                item = Instantiate(goldgrape);
            }

            //다이아 포도 소환
            else if (diamond <= this.mDirector.GetComponent<MainGameDirector>().diamondP)
            {
                item = Instantiate(diamondgrape);
            }

            else
            {
                item = Instantiate(grape);
            }

            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-3.5f, 3.5f);
            item.transform.position = new Vector3(x, y, 0);
        }
    }

    public void podoSpawn()
    {
        GameObject item = Instantiate(grape);

        float x = Random.Range(-6.5f, 6.5f);
        float y = Random.Range(-2.5f, 2.5f);
        item.transform.position = new Vector3(x, y, 0);
    }
}
