using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public void ButtonPush()
    {
        //押された時の処理
        Debug.Log("押されました。");
        //GetComponent<Button>().Select();
    }
}
