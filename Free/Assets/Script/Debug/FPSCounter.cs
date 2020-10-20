using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 必ずGetComponentでTextが取得できる事を保証する
[RequireComponent(typeof(Text))]
public class FPSCounter : MonoBehaviour
{
    [SerializeField] protected float m_samplingRateSec = 1.0f;

    protected Text m_text;
    protected int m_fpsCounter = 0;
    protected float m_befTime = 0;

    void Start()
    {
        m_text = this.GetComponent<Text>();
        m_text.text = "FPS:計測中";
        m_befTime = Time.time;
        m_fpsCounter = 0;
    }

    void Update()
    {
        UpdateFpsCounter();  
    }

    void UpdateFpsCounter()
    {
        m_fpsCounter++;
        float deltaTime = Time.time - m_befTime;
        if (deltaTime >= m_samplingRateSec)
        {
            const int roundPoint = 100;  // 少数第2位で四捨五入
            float fps = Mathf.Round((float)m_fpsCounter / deltaTime  * roundPoint) / roundPoint;

            deltaTime = 0;
            m_befTime = Time.time;
            m_fpsCounter = 0;
            m_text.text = "FPS:" + fps.ToString();
        }
    }
}
