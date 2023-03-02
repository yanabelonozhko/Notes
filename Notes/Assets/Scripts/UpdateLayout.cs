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
        // Создаем новый объект на основе префаба
        GameObject newRectangle = Instantiate(rectanglePrefab);



        // Добавляем новый объект в список дочерних объектов вертикальной группы
        var verticalLayoutGroup = GameObject.FindWithTag("ScrollArea");

        

        newRectangle.transform.SetParent(verticalLayoutGroup.transform);
    } 
}
