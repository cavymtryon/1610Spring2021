using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBehaviour : MonoBehaviour
{
   public int number = 3;
   public float holdTime  = 1f;
   public Text countDownText;

   private WaitForSeconds wfsobj;

    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(holdTime);
        while (number > 0)
        {
            countDownText.text = number.ToString();
            number --;
            yield return wfsobj;
            }

            countDownText.text = "Go!";

            yield return wfsobj;

            countDownText.text = null;
    }
}
