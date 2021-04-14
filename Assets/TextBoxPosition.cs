using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxPosition : MonoBehaviour
{
    public GameObject[] TextBox; //텍스트 박스
    public GameObject RoulletManager;
    public int div = 0; //룰렛의 분활된 면수
    // Start is called before the first frame update
    void Start()
    {
        div = RoulletManager.GetComponent<InstantiateScript>().div;
        switch (div)
        {
            case 2:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(180, 0);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-180, 0);
                Destroy(TextBox[2]);
                Destroy(TextBox[3]);
                Destroy(TextBox[4]);
                Destroy(TextBox[5]);
                Destroy(TextBox[6]);
                Destroy(TextBox[7]);
                break;
            case 3:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(170, 100);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(0, -200);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-170, 100);
                Destroy(TextBox[3]);
                Destroy(TextBox[4]);
                Destroy(TextBox[5]);
                Destroy(TextBox[6]);
                Destroy(TextBox[7]);
                break;
            case 4:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(160, 150);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(160, -140);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-160, -140);
                TextBox[3].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-160, 150);
                Destroy(TextBox[4]);
                Destroy(TextBox[5]);
                Destroy(TextBox[6]);
                Destroy(TextBox[7]);
                break;
            case 5:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(140, 180);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(220, -60);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(0, -220);
                TextBox[3].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-220, -60);
                TextBox[4].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-140, 180);
                Destroy(TextBox[5]);
                Destroy(TextBox[6]);
                Destroy(TextBox[7]);
                break;
            case 6:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(120, 200);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(220, 0);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(120, -200);
                TextBox[3].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-120, -200);
                TextBox[4].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-220, 0);
                TextBox[5].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-120, 200);
                Destroy(TextBox[6]);
                Destroy(TextBox[7]);
                break;
            case 7:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(110, 210);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(220, 50);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(190, -140);
                TextBox[3].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(0, -230);
                TextBox[4].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-190, -140);
                TextBox[5].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-220, 50);
                TextBox[6].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-110, 210);
                Destroy(TextBox[7]);
                break;
            case 8:
                TextBox[0].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(100, 220);
                TextBox[1].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(220, 80);
                TextBox[2].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(220, -80);
                TextBox[3].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(100, -220);
                TextBox[4].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-100, -220);
                TextBox[5].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-220, -80);
                TextBox[6].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-220, 80);
                TextBox[7].GetComponent<RectTransform>().anchoredPosition
                = new Vector2(-100, 220);
                break;
            default: break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
