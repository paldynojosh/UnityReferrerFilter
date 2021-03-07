
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class WebsiteCheckView : MonoBehaviour
{
    public enum FilterType
    {
        WhiteList,
        BlackList
    }

    [SerializeField]
    private FilterType m_filterType;
    [SerializeField]
    private List<string> m_list;

    [SerializeField]
    private GameObject m_button;

    [DllImport("__Internal")]
    private static extern string GetReferrerWithMalloc();

    void Start()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        if(!PassFilter(GetReferrerWithMalloc()))
        {
            m_button.SetActive(true);
            return;
        }
#endif
        m_button.SetActive(false);
        SceneManager.LoadScene(1);
    }

    private bool PassFilter(string referrer)
    {
        bool is_include = false;
        foreach(var url in m_list)
        {
            if(referrer.Contains(url))
            {
                is_include = true;
                break;
            }
        }
        if(m_filterType == FilterType.WhiteList)
        {
            return is_include;
        }
        return !is_include;
    }

}
