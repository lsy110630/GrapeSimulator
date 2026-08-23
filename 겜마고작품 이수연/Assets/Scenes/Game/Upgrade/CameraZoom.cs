using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    public CanvasScaler scaler;  

    public float zoomSpeed = 5f;    
    public float minSize = 2f;
    public float defaultSize = 5f;
    public float maxSize = 10f;

    private void Start()
    {
        defaultSize = cam.orthographicSize; // 카메라 초기 사이즈
    }

    void Update()
    {
        float wheel = Input.GetAxis("Mouse ScrollWheel");

        if (wheel != 0)
        {
            cam.orthographicSize -= wheel * zoomSpeed; // 휠로 변경된 카메라 사이즈
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize); // 최대최소 제한

            float zoom = defaultSize / cam.orthographicSize; // UI변경용 비율계산.
            scaler.scaleFactor = zoom;
        }
    }
}
