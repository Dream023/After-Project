using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    [SerializeField] GameObject Player, Enemy;
    [SerializeField] Image Fill;
    public Slider Health;
    public Gradient HPColor;
    public void SetMaxHealth(int MaxHP)
    {
        Health.maxValue = MaxHP;
        Health.value = MaxHP;
        Fill.color = HPColor.Evaluate(1f);
    }
    public void HealthBar(int HP)
    {
        Health.value = HP;
        Fill.color = HPColor.Evaluate(Health.normalizedValue);
    }
    

}
