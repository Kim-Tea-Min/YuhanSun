using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class PlusMinus : MonoBehaviour
{
    public TextMeshProUGUI mainText;
    public GameObject MinusButton;
    public GameObject PlusButton;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "2";
        score = 2;
    }
    public void Plus()
    {

        if (score > 7)
        {
            score = 8;
            mainText.text = score.ToString();
        }
        else
        {
            score = score + 1;
            mainText.text = score.ToString();
        }

    }

    public void Minus()
    {
        if (score < 3)
        {
            score = 2;
            mainText.text = score.ToString();
        }
        else
        {
            score = score - 1;
            mainText.text = score.ToString();
        }

    }
    public void OnClick()
    {
        SceneManager.LoadScene("ThirdScene");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 2)
        {
            score = 2;
            mainText.text = score.ToString();
            MinusButton.SetActive(false);
        }
        else
        {
            MinusButton.SetActive(true);
        }
        if (int.Parse(mainText.text) == 8)
        {
            score = 8;
            mainText.text = score.ToString();
            PlusButton.SetActive(false);
        }
        else
        {
            PlusButton.SetActive(true);
        }


    }

}
