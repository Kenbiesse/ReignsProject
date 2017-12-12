using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapImage : MonoBehaviour
{
    #region Public Members

    public Sprite[] m_spriteArray;
    public int m_pickAPic;
    public string m_picName;
    public Sprite m_pic;

    public void ChangePic()
    {
        m_pickAPic = Random.Range(0, 2);
        m_picName = m_pickAPic.ToString() + ".png";
        m_pic = (Sprite)Resources.Load(m_picName);
    }

    #endregion

    #region Public void

    #endregion

    #region System

    void Awake ()
    {
        m_pic = GetComponent<Image>().sprite;
	}
	
	void Update ()
    {
		
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members


    #endregion
}
