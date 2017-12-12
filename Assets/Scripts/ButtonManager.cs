using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region Public Members

    public Button m_yesButton;
    public Button m_noButton;
    public int m_yes = 0;
    public int m_no = 0;
    public Image m_pic;
    public Sprite[] m_pixArray;

    #endregion

    #region Public void

    #endregion

    #region System

    void Awake ()
    {
        m_yesButton.onClick.AddListener(YouClickedYes);
        m_noButton.onClick.AddListener(YouClickedNo);
//        m_pic = GetComponent<Sprite>();
        ChangePic();
    }
	
	void Update ()
    {
		
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private int m_pickAPic;
    private string m_picName;

    private void YouClickedYes()
    {
        m_yes++;
        Debug.Log("You clicked Yes!" + m_yes);
        ChangePic();
    }

    private void YouClickedNo()
    {
        m_no++;
        Debug.Log("You clicked No!" + m_no);
        ChangePic();
    }

    public void ChangePic()
    {
        m_pickAPic = Random.Range(0, 9);
        // m_picName = m_pickAPic.ToString() + ".png";
        // m_pic.sprite = (Sprite)Resources.Load(m_picName); --- Not working !!!
        m_pic.sprite = m_pixArray[m_pickAPic];
    }

    #endregion
}
