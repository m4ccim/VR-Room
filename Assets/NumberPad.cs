using TMPro;
using UnityEngine;

public class NumberPad : MonoBehaviour
{
    [SerializeField] private string sequence;
    [SerializeField] private GameObject keycardPrefab;
    [SerializeField] private TextMeshProUGUI inputDisplayText;    
    private string m_CurrentEnteredCode = "";
    public void ButtonPressed(int valuePressed)
    {
        m_CurrentEnteredCode += valuePressed;

        if (m_CurrentEnteredCode.Length == sequence.Length)
        {
            if (m_CurrentEnteredCode == sequence)
            {
                Instantiate(keycardPrefab, transform);
                Debug.Log("Correct!");
            }
            else
            {
                m_CurrentEnteredCode = string.Empty;
                Debug.Log("InCorrect!");
            }
        }
        inputDisplayText.SetText(m_CurrentEnteredCode);
    }

}