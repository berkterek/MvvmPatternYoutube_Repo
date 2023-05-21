using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelObjectSample2EnemyController : MonoBehaviour
{
    [SerializeField] EnemySO _enemySo;
    
    [Header("Ui Elements")]
    [SerializeField] TMP_Text _titleText;
    [SerializeField] TMP_Text _levelUpgradeText;
    [SerializeField] TMP_Text _scoreUpgradeText;
    [SerializeField] Button _levelUpgradeButton;
    [SerializeField] Button _scoreUpgradeButton;

    void Awake()
    {
        _titleText.SetText(_enemySo.name);
        _levelUpgradeText.SetText(_enemySo.LevelValue.ToString());
        _scoreUpgradeText.SetText(_enemySo.ScoreValue.ToString());
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
        _enemySo.LevelValue++;
        _levelUpgradeText.SetText(_enemySo.LevelValue.ToString());
    }
    
    void HandleOnScoreUpgradeClicked()
    {
        _enemySo.ScoreValue++;
        _scoreUpgradeText.SetText(_enemySo.ScoreValue.ToString());
    }
}