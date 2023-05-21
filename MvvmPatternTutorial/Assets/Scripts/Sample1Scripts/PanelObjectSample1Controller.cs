using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelObjectSample1Controller : MonoBehaviour
{
    [Header("Data Elements")] 
    [SerializeField] string _titleName;
    [SerializeField] int _levelValue = 1;
    [SerializeField] int _scoreValue = 0;
    
    [Header("Ui Elements")]
    [SerializeField] TMP_Text _titleText;
    [SerializeField] TMP_Text _levelUpgradeText;
    [SerializeField] TMP_Text _scoreUpgradeText;
    [SerializeField] Button _levelUpgradeButton;
    [SerializeField] Button _scoreUpgradeButton;

    void Awake()
    {
        _titleText.SetText(_titleName);
        _levelUpgradeText.SetText(_levelValue.ToString());
        _scoreUpgradeText.SetText(_scoreValue.ToString());
    }

    void OnEnable()
    {
        _levelUpgradeButton.onClick.AddListener(HandleOnLevelUpgradeClicked);
        _scoreUpgradeButton.onClick.AddListener(HandleOnScoreUpgradeClicked);
    }

    void OnDisable()
    {
        _levelUpgradeButton.onClick.RemoveListener(HandleOnLevelUpgradeClicked);
        _scoreUpgradeButton.onClick.RemoveListener(HandleOnScoreUpgradeClicked);
    }
    
    void HandleOnLevelUpgradeClicked()
    {
        _levelValue++;
        _levelUpgradeText.SetText(_levelValue.ToString());
    }
    
    void HandleOnScoreUpgradeClicked()
    {
        _scoreValue++;
        _scoreUpgradeText.SetText(_scoreValue.ToString());
    }
}