using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] private UnityEngine.Experimental.Rendering.Universal.Light2D _light;

    float duration = 0.1f;
    Color color0 = Color.red;
    Color color1 = Color.blue;
    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        _light.color = Color.Lerp(color0, color1, t);

        _light.intensity += 0.001f;
        _light.pointLightOuterRadius += 0.0001f;
        _light.pointLightOuterAngle += 0.0001f;

        /*if (Input.GetKeyDown(KeyCode.Q))
        {
           _light.Color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
           _light.Color = Color.blue;
        }
        */
    }
}
