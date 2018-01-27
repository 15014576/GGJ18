using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cinematic : MonoBehaviour
{
    public RumoursForTheDay rumoursForTheDay;
    List<PanelInfo> dialog;
    int PIindex, panelIndex;

    public float textSpeed;

    public GameObject _SettingPanel;
    public GameObject _SettingText;
    public GameObject _SpeechPanel;
    public GameObject _NamePanel;
    public GameObject _Background;
    public GameObject _LeftImage;
    public GameObject _RightImage;
    public GameObject _CentreImage;
    public GameObject _NameText;
    public GameObject _ConvoText;

    TextMeshProUGUI settingText;
    Image background;
    Image leftImage;
    Image rightImage;
    Image centreImage;
    TextMeshProUGUI nameText;
    TextMeshProUGUI convoText;

    private void Start()
    {
        dialog = new List<PanelInfo>();

        settingText = _SettingText.GetComponent<TextMeshProUGUI>();
        background = _Background.GetComponent<Image>();
        leftImage = _LeftImage.GetComponent<Image>();
        rightImage = _RightImage.GetComponent<Image>();
        centreImage = _CentreImage.GetComponent<Image>();
        nameText = _NameText.GetComponent<TextMeshProUGUI>();
        convoText = _ConvoText.GetComponent<TextMeshProUGUI>();

        ShowRumours();
    }

    public void ShowRumours()
    {
        List<PanelInfo> _dialog = new List<PanelInfo>();
        List<Rumour> rum = rumoursForTheDay.rumours;

        for(int i=0; i<rum.Count;i++)
        {
            _dialog.Add(rum[i].opening);
        }

        Show(_dialog);
    }

    public void ShowOutcomes()
    {

    }

    void Show(List<PanelInfo> _dialog)
    {
        dialog = _dialog;
        PIindex = 0;
        panelIndex = 0;
        PanelParse(dialog[PIindex].panels[panelIndex]);
    }

    public void NextPanel()
    {
        panelIndex++;
        PanelParse(dialog[PIindex].panels[panelIndex]);
    }

    void PanelParse(Panel p)
    {
        _SettingPanel.SetActive(false);
        _SpeechPanel.SetActive(false);
        _NamePanel.SetActive(false);
        _SettingText.SetActive(false);
        _NameText.SetActive(false);
        _ConvoText.SetActive(false);


        switch(p.typeOfPanel)
        {
            case PanelType.Setting:
                settingText.text = p.text;
                _SettingText.SetActive(true);
                _SettingPanel.SetActive(true);
                break;
            case PanelType.One_Person:
                nameText.text = p.nameOfSpeaker;
                _NameText.SetActive(true);
                if (nameText.text != "")
                {
                    _NamePanel.SetActive(true);
                }
                convoText.text = p.text;
                _ConvoText.SetActive(true);
                _SpeechPanel.SetActive(true);
                break;
            case PanelType.Two_Person:
                nameText.text = p.nameOfSpeaker;
                _NameText.SetActive(true);
                convoText.text = p.text;
                _ConvoText.SetActive(true);
                _SpeechPanel.SetActive(true);
                break;
        }
    }
}
