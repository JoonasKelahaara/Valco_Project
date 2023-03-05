using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine2 : MonoBehaviour
{
    public GameObject player;
    public GameObject machine2;
    public GameObject machine2Popup;
    public GameObject Clock;
    public GameObject CoinText;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((machine2.transform.position - player.transform.position).sqrMagnitude < 5.0f && Input.GetKeyDown(KeyCode.E))
        {
            //ottaa muun uin pois, est�� hahmoa liikkumasta ja avaa minipeli ikkunan
            CoinText.SetActive(false);
            Clock.SetActive(false);
            Player.SetActive(false);
            machine2Popup.SetActive(true);
        }
            
    }
}
