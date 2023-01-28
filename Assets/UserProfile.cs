using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserProfile
{
    private Sprite UserIcon = null;
    private string UserName = null;
    private uint month = 0, day = 0;
    private string UserComment = null;

    public void Sprite_set(Sprite S)
    {
        UserIcon = S;
    }

    public Sprite Sprite_get()
    {
        return UserIcon;
    }

    public void Name_set(string Name)
    {
        UserName = Name;
    }

    public string Name_get()
    {
        return UserName;
    }

    public void Birthday_set(uint m, uint d)
    {
        month = m;
        day = d;
    }

    public (uint, uint) Birthday_get()
    {
        return (month, day);
    }

    public void Comment_set(string Comment)
    {
        UserComment = Comment;
    }

    public string Comment_get()
    {
        return UserComment;
    }
}
