using UnityEngine;

public class CircleController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player");  // 플레이어 찾고
    }

    void Update()
    {
        this.transform.position = this.player.transform.position; // 좌표 이동
    }  
}
