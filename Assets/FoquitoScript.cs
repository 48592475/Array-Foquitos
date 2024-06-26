﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;
    public int secuencia = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        //importante
        currentLightIndex++;
        if (currentLightIndex >= colors.Length)
        {
            currentLightIndex = 0;
            secuencia++;
            if (secuencia >= 3)
            {
                borrar();
            }
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
        
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
        borrar();
    }

    void DeactivateAllLights()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].SetActive(false);
        }
    }
    
    public void ActivateRepeating(float t)
    {
        //instanciar
        InvokeRepeating(nameof(ActivateNextLight), 0, t);
        
       
    }
    public void borrar()
    {
        Destroy(gameObject);
    }

}
