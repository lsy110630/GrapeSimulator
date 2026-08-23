using UnityEngine;

public class ScissorsPodo : MonoBehaviour
{
    GameObject director;
    float span = 3.0f;       // 사라질떄까지 시간
    float delta = 0;         // 시간재기
    bool one = true;         // 한번만 카운트

    private void Awake()
    {
        this.director = GameObject.Find("MainDirector");
    }

    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 한번 서클과 닿았을떄 일정확률로 바로 부숴짐
        if ((one == true) && (collision.gameObject.tag == "Circle"))
        {
            one = false;
            int dice = Random.Range(1, 100001);
            if (dice <= this.director.GetComponent<MainGameDirector>().bP)
            {
                this.director.GetComponent<MainGameDirector>().podo += 1;
                this.director.GetComponent<MainGameDirector>().EX += 1 + this.director.GetComponent<MainGameDirector>().addEX;

                int dice2 = Random.Range(1, 100001);
                if (dice2 <= this.director.GetComponent<MainGameDirector>().pSP)
                {
                    // 포도생성 함수실행
                    this.director.GetComponent<GrapeGenerator>().podoSpawn();
                }

                this.director.GetComponent<MainGameDirector>().scissorspodo = 1;

                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            this.delta += Time.deltaTime;
            if (this.delta > span)
            {
                // podo랑 경험치에 +1
                this.director.GetComponent<MainGameDirector>().podo += 1;
                this.director.GetComponent<MainGameDirector>().EX += 1 + this.director.GetComponent<MainGameDirector>().addEX;

                // 포도가 사라질떄마다 일정 확률로 포도가 생성되게 처음엔 아예 확률이 없지만 업그레이드를 하면 확룰이 조금씩생기는 그런
                int dice = Random.Range(1, 100001);  //   원래 100에 1이 1% 1000 1 0.1% 10000 1 0.01% 100000 1 0.001%
                if (dice <= this.director.GetComponent<MainGameDirector>().pSP)
                {
                    // 포도생성 함수실행
                    this.director.GetComponent<GrapeGenerator>().podoSpawn();
                }

                this.director.GetComponent<MainGameDirector>().scissorspodo = 1;    // 아티팩트를 먹은걸 표시
                
                Destroy(this.gameObject);             // 없어진다
            }
        }
    }
}
