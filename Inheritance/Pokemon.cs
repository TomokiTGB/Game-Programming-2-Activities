using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pokemon : MonoBehaviour
{
    public int id;
    public string name;
    public Gender gender;
    public Types types;
    public int hp;
    public int atk;
    public int spatk;
    public int def;
    public int spdef;
    public int spd;
    //public Sprite image;

    public TextMeshProUGUI dexNo;
    public TextMeshProUGUI monName;
    public TextMeshProUGUI monGender;
    public TextMeshProUGUI monTypes;
    public TextMeshProUGUI monHp;
    public TextMeshProUGUI monAtk;
    public TextMeshProUGUI monSpAtk;
    public TextMeshProUGUI monDef;
    public TextMeshProUGUI monSpDef;
    public TextMeshProUGUI monSpd;
    
    public void BtnUpdate()
    {
        dexNo.text = id.ToString();
        monName.text = name.ToString();
        monGender.text = gender.ToString();
        monTypes.text = types.ToString();
        monHp.text = hp.ToString();
        monAtk.text = atk.ToString();
        monSpAtk.text = spatk.ToString();
        monDef.text = def.ToString();
        monSpDef.text = spdef.ToString();
        monSpd.text = spd.ToString();
    }

}
