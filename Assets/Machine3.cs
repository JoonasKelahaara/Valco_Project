using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine3 : MonoBehaviour
{
    public GameObject Completed_Text;
    public List<Color> _wireColors = new List<Color>();
    public List<Wire> _leftWires = new List<Wire>();
    public List<Wire> _rightWires = new List<Wire>();
    private List<Color> _availableColors;
    private List<int> _availableLeftWireIndex;
    private List<int> _availableRightWireIndex;
    public Wire CurrentDraggedWire;
    public Wire CurrentHoveredWire;
    public bool IsTaskCompleted = false;

    public void Start()
    {
        _availableColors = new List<Color>(_wireColors);
        _availableLeftWireIndex = new List<int>();
        _availableRightWireIndex = new List<int>();

        for (int i = 0; i < _leftWires.Count; i++) { _availableLeftWireIndex.Add(i); }
        for (int i = 0; i < _rightWires.Count; i++) { _availableRightWireIndex.Add(i); }

        while (_availableColors.Count > 0 && _availableLeftWireIndex.Count > 0 && _availableRightWireIndex.Count > 0) {
            Color pickedColor = _availableColors[Random.Range(0, _availableColors.Count)];
            int pickedLeftWireIndex = Random.Range(0, _availableLeftWireIndex.Count);
            int pickedRightWireIndex = Random.Range(0, _availableRightWireIndex.Count);

            _leftWires[_availableLeftWireIndex[pickedLeftWireIndex]].SetColor(pickedColor);
            _rightWires[_availableRightWireIndex[pickedRightWireIndex]].SetColor(pickedColor);

            _availableColors.Remove(pickedColor);
            _availableLeftWireIndex.RemoveAt(pickedLeftWireIndex);
            _availableRightWireIndex.RemoveAt(pickedRightWireIndex);
        }
            StartCoroutine(CheckTaskCompletion());
    }

    private IEnumerator CheckTaskCompletion() {
        while(!IsTaskCompleted) {
            int successfullWires = 0;

            for (int i = 0; i < _rightWires.Count; i++) {
                if(_rightWires[i].IsSuccess) {
                    successfullWires++;
                }

                if(successfullWires >= _rightWires.Count) {
                    Debug.Log("Task Successfull!");
                    IsTaskCompleted = true;
                    Completed_Text.SetActive(true);
                } else {
                    Debug.Log("Task in progress...");
                }

                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}
