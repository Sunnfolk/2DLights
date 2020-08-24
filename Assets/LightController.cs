using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    [SerializeField] private GameObject _lights;
    private UnityEngine.Experimental.Rendering.Universal.Light2D _lt;

    // Start is called before the first frame update
    void Start()
    {

        _lt = _lights.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();

    }

    // Update is called once per framez
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _lt.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _lt.color = Color.blue;
        }
    }
}
