using UnityEngine;
using System.Collections;
using System;

public class ImageTop : MonoBehaviour {

    public delegate void ClickAction();
    public static event ClickAction OnClickedUp;
    public static event ClickAction OnClickedDown;

    void OnMouseUp()
    {
        if (OnClickedUp != null)
            OnClickedUp();    
    }

    void OnMouseDown()
    {
        if (OnClickedDown != null)
            OnClickedDown();
    }
}
