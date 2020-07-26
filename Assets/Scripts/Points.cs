using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text text;

    [SerializeField]
    private int points=0;

    public GameObject popup;

    public Transform Canvas;

    void Update()
    {
        text.text = points.ToString();
    }

    public void addPoints(int p)
    {
        points += p;
        popup.GetComponent<Text>().text = p.ToString();
        GameObject temp = Instantiate(popup, Canvas);
        temp.GetComponent<RectTransform>().position = Input.mousePosition;
    }
}
