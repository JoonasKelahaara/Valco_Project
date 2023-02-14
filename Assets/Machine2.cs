using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine2 : MonoBehaviour
{
    public GameObject player;
    public GameObject machine2;
    public GameObject machine2Popup;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((machine2.transform.position - player.transform.position).sqrMagnitude < 5.0f && Input.GetKeyDown(KeyCode.E))
        {
            machine2Popup.SetActive(true);
            Debug.Log("Hello: ");
        }
            
    }
}
