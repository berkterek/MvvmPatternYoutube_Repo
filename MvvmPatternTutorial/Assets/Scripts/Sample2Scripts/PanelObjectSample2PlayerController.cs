using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelObjectSample2PlayerController : MonoBehaviour
{
    [SerializeField] PlayerSO _playerSo;
    
    [Header("Ui Elements")]
    [SerializeField] TMP_Text _titleText;
    [SerializeField] TMP_Text _levelUpgradeText;
    [SerializeField] TMP_Text _scoreUpgradeText;
    [SerializeField] Button _levelUpgradeButton;
    [SerializeField] Button _scoreUpgradeButton;

    void Awake()
    {
        _titleText.SetText(_playerSo.name);
        _levelUpgradeText.SetText(_playerSo.LevelValue.ToString());
        _scoreUpgradeText.SetText(_playerSo.ScoreValue.ToString());
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
        _playerSo.LevelValue++;
        _levelUpgradeText.SetText(_playerSo.LevelValue.ToString());
    }
    
    void HandleOnScoreUpgradeClicked()
    {
        _playerSo.ScoreValue++;
        _scoreUpgradeText.SetText(_playerSo.ScoreValue.ToString());
    }
}