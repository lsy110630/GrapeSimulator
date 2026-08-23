using UnityEngine;

public class CircleController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        this.transform.position = this.player.transform.position; // ÁÂÇ¥ ÀÌµ¿
    }  
}
