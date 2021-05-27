using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject[] canvas;
    //ĵ������ ����
    public GameObject RoulletManager;
    public GameObject[] input;
    public GameObject Button_reset;

    public Text[] set_text;
    public Text[] get_text;
    public Text text_res;

    public string[] text = new string[8];
    public int canvas_order;
    //ĵ������ ������ ����
    public int canvas_num;
    //ĵ������ �� ����
    public int div, sector;
    
    
    public float rotationSpeed;
    public float rnd, angle; //rnd 0�� 1������ float�� ����
    //angle : ���° �鿡 �ɸ��� + ����(sector + rnd - 1)
    bool act = true; //abc

    // Start is called before the first frame update
    void Start()
    {
       Button_reset.SetActive(false);
       div = NumberCounter.numeber;
       act = true;

       rnd = Random.Range(1.000f, 0.000f);
       //rnd : 0�� 1������ float�� ��������  

       canvas_order = 0; //�ʱⰪ ����
       canvas_num = 2;
       Canvas_changed();

    }

    // Update is called once per frame
    void Update()
    {
        angle = sector + rnd - 1; ;
        //RoulletManager���� angle���� �޾ƿ�
        rotationSpeed *= 1 - 0.01f * div / (div + angle);
        //������ order*(360��/div)��ŭ �߰��� �̵�(order : div�� ����)

        for (int i = div; i < get_text.Length; i++)
        {
            input[i].GetComponent<InputField>().interactable = false;
        }
        for (int i = 0; i < get_text.Length; i++)
        {
            if (get_text[i].text != "")
            {
                text[i] = get_text[i].text;
            }
            else
            {
                text[i] = (i + 1).ToString();
            }
        }
        
        for (int i = 0; i < text.Length; i++)
        {
                set_text[i].text = text[i];
        }
        

        if (rotationSpeed<=0.01 && !act)
        {
            Button_reset.SetActive(true);

            if (sector == 0)
            {
                text_res.text = "\"\"";
            }
            else
            {
                text_res.text = "\"" + text[sector - 1] + "\"";
            }
        }


        if (canvas_order == 2 && Input.GetMouseButtonDown(0) && act)
        {
            if (act)
            {
                rotationSpeed = 3.6f; //ȸ���ӵ� 3.6��
                act = false; //���콺 Ŭ���� �Լ��� �ѹ��� �����ϰ� ��
            }
            
        }
    }

    public void Canvas_changed() //���� ĵ������ �Ѿ�� �Լ�
    {
        if (canvas_order <= canvas_num) canvas_order++; //���� ĵ������
        for (int i = 1; i <= canvas_num; i++)
        {
            if (canvas_order == i)
            {
                for (int n = 0; n < canvas_num; n++)
                { canvas[n].SetActive(false); } //ĵ���� �����
                canvas[i - 1].SetActive(true);  //ĵ���� �����
            }
            RoulletManager.GetComponent<InstantiateScript>().div = div;
        } 
        
    }
   
}
