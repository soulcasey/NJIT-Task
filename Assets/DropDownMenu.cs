using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    public static int scene, objecttype, color;
    public Dropdown SceneDrop;
    public Dropdown ObjectDrop;
    public Dropdown ColorDrop;

    void Start()
    {
    }

    private void FixedUpdate()
    {
        SceneDrop.GetComponent<Dropdown>().value = scene;
        ObjectDrop.GetComponent<Dropdown>().value = objecttype;
        ColorDrop.GetComponent<Dropdown>().value = color;
    }

    public void SceneMenu(int x)
    {
        scene = x;
    }

    public void ObjectMenu(int y)
    {
        objecttype = y;
    }
    public void ColorMenu(int z)
    {
        color = z;
    }

    public void RandomMenu()
    {
        scene = UnityEngine.Random.Range(0, 3);
        objecttype = UnityEngine.Random.Range(0, 3);
        color = UnityEngine.Random.Range(0, 3);
    }

}
