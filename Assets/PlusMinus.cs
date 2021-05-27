using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlusMinus : MonoBehaviour
{
  public UnityEngine.UI.Text mainText;
  public GameObject MinusButton;
  public GameObject PlusButton;

  private int nextnumber;

  // Start is called before the first frame update
  void Start()
  {
    mainText.text = "2";
    nextnumber = 2;
  }
  public void Plus()
  {

    if (int.Parse(mainText.text) > 7)
    {
      nextnumber = 8;
      mainText.text = nextnumber.ToString();
    }
    else
    {
      nextnumber = int.Parse(mainText.text) + 1;
      mainText.text = nextnumber.ToString();
    }
    Debug.Log(nextnumber);
  }

  public void Minus()
  {
    nextnumber = 0;

    if (int.Parse(mainText.text) < 3)
    {
      nextnumber = 2;
      mainText.text = nextnumber.ToString();
    }
    else
    {
      nextnumber = int.Parse(mainText.text) - 1;
      mainText.text = nextnumber.ToString();
    }
    Debug.Log(nextnumber);
  }
  public void OnClick()
  {
    SceneManager.LoadScene("ThirdScene");
    NumberCounter.numeber = nextnumber;
  }

  // Update is called once per frame
  void Update()
  {
    int nextnumber = 0;
    if (int.Parse(mainText.text) == 2)
    {
      nextnumber = 2;
      mainText.text = nextnumber.ToString();
      MinusButton.SetActive(false);
    }
    else
    {
      MinusButton.SetActive(true);
    }
    if (int.Parse(mainText.text) == 8)
    {
      nextnumber = 8;
      mainText.text = nextnumber.ToString();
      PlusButton.SetActive(false);
    }
    else
    {
      PlusButton.SetActive(true);
    }


  }

}
