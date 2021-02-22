using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPanel : MonoBehaviour
{
    [SerializeField] int btnCnt;

    public void Unset()
    {
        gameObject.SetActive(false);
    }
}
