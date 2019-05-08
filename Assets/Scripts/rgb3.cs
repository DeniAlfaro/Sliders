using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rgb3 : MonoBehaviour
{
    Renderer render;

    [SerializeField]
    Slider _R;
    [SerializeField]
    Slider _G;
    [SerializeField]
    Slider _B;

    private void Start()
    {
        render = GetComponent<Renderer>();

    }

    private void Update()
    {
        render.material.SetFloat("_R", _R.value);
        render.material.SetFloat("_G", _G.value);
        render.material.SetFloat("_B", _B.value);
    }

}
