using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ImpoManage : MonoBehaviour
{
    public GameObject impoPanel;
    public GameObject tastoImpostazioni;

    // Start is called before the first frame update
    void Start()
    {
        impoPanel.SetActive(false);
    }

    //Da assegnare all'OnlClick del bottone impostazioni
    public void TastoImpoOn()
    {
        Debug.Log("Hai aperto il pannello delle impostazioni");
        tastoImpostazioni.SetActive(false);
        impoPanel.SetActive(true);
    }

    //Da assegnare all'OnlClick del bottone con la v
    public void TastoImpoOff()
    {
        Debug.Log("Hai chiuso il pannelo delle impostazioni");
        tastoImpostazioni.SetActive(true);
        impoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
