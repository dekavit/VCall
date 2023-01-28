using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] Screen;
    int State = 1;
    void Start()
    {
        CamvasUpdate(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CamvasUpdate(int state_update)
    {
        Screen[State].SetActive(false);
        State = state_update;
        Screen[State].SetActive(true);
    }
}
