using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class LinkButtonBridge : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenLink(string url);

    [SerializeField]
    private string m_link;

    public void OnClickLink()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenLink(m_link);
#else
        Application.OpenURL(m_link);
#endif
    }
}
