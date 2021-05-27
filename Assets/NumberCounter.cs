using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberCounter : MonoBehaviour
{
  public static int numeber = 2;

   public void Scene_Reset()
   {
        SceneManager.LoadScene("SecondScene");
   }
}
