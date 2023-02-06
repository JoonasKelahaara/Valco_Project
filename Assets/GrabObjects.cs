using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{

    [SerializeField] private Transform rayPoint;
    [SerializeField] private Transform grabPoint;
    [SerializeField] private float rayDistance;
    private GameObject box;
    private int layerIndex;

    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Box");
    }
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance);

        if(hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            if(Input.GetKeyDown(KeyCode.E) && box == null)
            {
                box = hitInfo.collider.gameObject;
                box.GetComponent<Rigidbody2D>().isKinematic = true;
                box.transform.position = grabPoint.position;
                box.transform.SetParent(transform);
            }
            else if(Input.GetKeyDown(KeyCode.E))
            {
                box.GetComponent<Rigidbody2D>().isKinematic = false;
                box.transform.SetParent(null);
                box = null;
            }
        }
    }
}