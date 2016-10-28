using UnityEngine;
using System.Collections;

public class titleBuilding : MonoBehaviour {

    [SerializeField]
    private GameObject break_Building;
    [SerializeField]
    private GameObject building;

    private int durability = 60;

    void Update()
    {
        building.transform.eulerAngles = new Vector3(-90, 0, 0);

        if (building.transform.position.y >= 0)
        {
            durability--;
        }
        else
        {
            building.transform.Translate(transform.up * -0.1f);
        }

        //耐久度が0なら差し替え
        if (durability <= 0)
        {
            Instantiate(break_Building,
            building.transform.localPosition,
                        Quaternion.identity);

            //元のオブジェクト消去
            Destroy(this.gameObject);
        }
    }
}
