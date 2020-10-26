using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpoManage : MonoBehaviour
{
    public GameObject impoPanel;

    // Start is called before the first frame update
    void Start()
    {
        impoPanel.SetActive(false);
    }

    public void TastoImpoOn()
    {
        impoPanel.SetActive(true);
    }

    public void TastoImpoOff()
    {
        impoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
