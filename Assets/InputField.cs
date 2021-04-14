using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
    //¡¶¿€¡ﬂ
{
    public Text[] set_text;
    public Text[] get_text;
    string[] text = new string[8];



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < get_text.Length; i++)
        {
              text[i] = get_text[i].text;
        }
        for (int i = 0; i < text.Length; i++)
        {
            set_text[i].text = text[i];
        }
    }

    public void Inherit_text()
    {
        
    }
}
