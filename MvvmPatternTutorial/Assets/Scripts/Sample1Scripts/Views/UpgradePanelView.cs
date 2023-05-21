using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelView : MonoBehaviour
{
    [Header("Ui Elements")]
    [SerializeField] TMP_Text _titleText;
    [SerializeField] TMP_Text _levelUpgradeText;
    [SerializeField] TMP_Text _scoreUpgradeText;
    [SerializeField] Button _levelUpgradeButton;
    [SerializeField] Button _scoreUpgradeButton;
    [SerializeField] UpgradeViewModel _upgradeViewModel;

    void OnValidate()
    {
        if (_upgradeViewModel == null)
        {
            _upgradeViewModel = GetComponent<UpgradeViewModel>();
        }
    }

    void Start()
    {
        _titleText.SetText(_upgradeViewModel.TitleName);
        _levelUpgradeText.SetText(_upgradeViewModel.LevelValue.ToString());
        _scoreUpgradeText.SetText(_upgradeViewModel.ScoreValue.ToString());
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
        _levelUpgradeText.SetText(_upgradeViewModel.LevelIncrease());
    }
    
    void HandleOnScoreUpgradeClicked()
    {
        _scoreUpgradeText.SetText(_upgradeViewModel.ScoreIncrease());
    }
}
