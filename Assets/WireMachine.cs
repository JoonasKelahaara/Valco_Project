using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireMachine : MonoBehaviour
{
    public GameObject player;
    public GameObject machine3;
    public GameObject machine3Popup;
    public GameObject Clock;
    public GameObject CoinText;
    public GameObject Player;


    void Update()
    {
        if ((machine3.transform.position - player.transform.position).sqrMagnitude < 5.0f && Input.GetKeyDown(KeyCode.E))
        {
            //ottaa muun uin pois, est�� hahmoa liikkumasta ja avaa minipeli ikkunan
            CoinText.SetActive(false);
            Clock.SetActive(false);
            Player.SetActive(false);
            machine3Popup.SetActive(true);
        }
    }
}
