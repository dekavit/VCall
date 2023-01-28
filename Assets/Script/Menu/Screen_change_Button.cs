using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_change_Button : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TitleSceneButton titleSceneButton;
    [SerializeField] int State_Number;

    public void OnClickChageButton()
    {
        titleSceneButton.CamvasUpdate(State_Number);
    }
}
