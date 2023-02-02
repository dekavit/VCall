using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomList : MonoBehaviour
{
    [SerializeField] GameObject RoomPrefab;
    [SerializeField] List<GameObject> Roomlist;
    [SerializeField] RectTransform Content;
    int N = 0;
    // Start is called before the first frame update
    void Start()
    {
        Content = this.GetComponent<RectTransform>();
        N = Roomlist.Count;
        Vector2 sd = Content.sizeDelta;
        sd.y = 0;
        Content.sizeDelta = sd;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Add();
        }
    }
    void Add()
    {
        Roomlist.Add(Instantiate(RoomPrefab, this.transform.position, Quaternion.identity));
        Roomlist[N].transform.parent = this.transform;
        Roomlist[N].GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Roomlist[N].GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -90f * N - 45f);

        N = Roomlist.Count;
        Vector2 sd = Content.sizeDelta;
        sd.y = N * 90;
        Content.sizeDelta = sd;
    }
}
