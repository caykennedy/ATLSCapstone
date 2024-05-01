using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class fader : MonoBehaviour
{
    [SerializeField] private CanvasGroup fadingui;
    private bool isFaded = true;

    public void Fader()
    {
        isFaded = !isFaded;

        if (!isFaded)
        {
            fadingui.DOFade(1,2);
        }
    }
}
