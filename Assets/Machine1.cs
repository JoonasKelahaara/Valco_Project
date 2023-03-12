using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine1 : MonoBehaviour
{
    public GameObject box;
    public float spawnRate = 2;
    private float timer = 0;
    public float widthOffset = 10;
    public Machine3 _wireTask;
    public Main _lightTask;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_wireTask.IsTaskCompleted && _lightTask.isTaskCompleted){
            Debug.Log("Tasks Completed");
            timer = timer + Time.deltaTime;
            spawnBox();
            timer = 0;
            //Ei resetaa taskeja, mutta lopettaa loputtoman box spawnin 
            _wireTask.IsTaskCompleted = false;
            _lightTask.isTaskCompleted = false;
        } else {
            Debug.Log("Tasks in progress");
        }

        
    }

    void spawnBox()
    {
        float leftOffset = transform.position.x - widthOffset;
        float rightOffset = transform.position.x + widthOffset;
        Instantiate(box, new Vector3(Random.Range(leftOffset, rightOffset), transform.position.y, 0), transform.rotation);
    }
}
