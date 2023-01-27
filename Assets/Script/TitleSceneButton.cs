using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] Screen;
    [SerializeField] GameObject NowScreen;
    public int State = -1;
    void Start()
    {
        CamvasUpdate();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CamvasUpdate()
    {
        State++;
        Destroy(NowScreen);
        NowScreen = Instantiate(Screen[State]);
    }
}
