using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLayout : MonoBehaviour
{
    public GameObject rectanglePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewNoteToLayout()
    {
        // ������� ����� ������ �� ������ �������
        GameObject newRectangle = Instantiate(rectanglePrefab);



        // ��������� ����� ������ � ������ �������� �������� ������������ ������
        var verticalLayoutGroup = GameObject.FindWithTag("ScrollArea");

        

        newRectangle.transform.SetParent(verticalLayoutGroup.transform);
    } 
}
