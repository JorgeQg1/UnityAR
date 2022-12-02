using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTargetTracked() {
        Debug.Log("JAJA");
        gameObject.SetActive(true);
    }

    public void OnTargetUntracked() {
        Debug.Log("JEJE");
        gameObject.SetActive(false);
    }
}
