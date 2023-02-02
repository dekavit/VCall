using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomButton : MonoBehaviour
{
    [SerializeField] string RoomName, Comment;
    [SerializeField] Text CommentText, RoomNameText;
    [SerializeField] Image image;
    [SerializeField] Sprite sprite, default_img;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CommentText.text = Comment;
        RoomNameText.text = RoomName;
        if (sprite == null)
        {
            image.sprite = default_img;
        }
        else
        {
            image.sprite = sprite;
        }
    }

    public void SetSprite(Sprite s)
    {
        sprite = s;
        image.sprite = s;
    }
}
