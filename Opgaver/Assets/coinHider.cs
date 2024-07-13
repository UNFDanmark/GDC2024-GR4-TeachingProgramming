using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinHider : MonoBehaviour
{
    public GameObject coinModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       coinModel.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        coinModel.SetActive(true);
    }
}
