using UnityEngine;
using System.Collections;

public class resultManager : MonoBehaviour
{

    [SerializeField]
    private Vector2 position = Vector2.zero;
    [SerializeField]
    private Vector2 size = Vector2.zero;

    //テストテキスト
    [SerializeField]
    private UnityEngine.UI.Text nameText;

    private string playerName = "hoge";

    void OnGUI()
    {
        playerName = GUI.TextField(new Rect(position, size), playerName, 5);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //入力テスト
        //#if UNITY_EDITER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            nameText.text = playerName;
        }
        //#endif
    }

    public void NameSave()
    {
        nameText.text = playerName;
    }
}

