//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.IO;



public class ActorAttributeTable : BaseTxtTable<ActorAttributeTable>
{
    
    public string XlsxMapping = "Actor.xlsx";
    
    /// <summary>
    /// 索引
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 等级
    /// </summary>
    public int Lv;
    
    /// <summary>
    /// 生命
    /// </summary>
    public int MaxHP;
    
    /// <summary>
    /// 法力
    /// </summary>
    public int MaxMP;
    
    /// <summary>
    /// 物理攻击
    /// </summary>
    public int AttackDamage;
    
    /// <summary>
    /// 法术攻击
    /// </summary>
    public int AttackPower;
    
    /// <summary>
    /// 物理防御
    /// </summary>
    public int DefenseDamage;
    
    /// <summary>
    /// 法术防御
    /// </summary>
    public int DefensePower;
    
    /// <summary>
    /// 物理穿透
    /// </summary>
    public int PenetrateDamage;
    
    /// <summary>
    /// 法术穿透
    /// </summary>
    public int PenetratePower;
    
    /// <summary>
    /// 物理吸血
    /// </summary>
    public int BloodDamage;
    
    /// <summary>
    /// 法术吸血
    /// </summary>
    public int BloodPower;
    
    /// <summary>
    /// 暴击
    /// </summary>
    public int Critical;
    
    /// <summary>
    /// 暴击伤害
    /// </summary>
    public int CriticalDamage;
    
    /// <summary>
    /// 暴击抵抗
    /// </summary>
    public int CriticalRes;
    
    /// <summary>
    /// 生命回复
    /// </summary>
    public int HPRegen;
    
    /// <summary>
    /// 法力回复
    /// </summary>
    public int MPRegen;
    
    /// <summary>
    /// 韧性
    /// </summary>
    public int Ductility;
    
    /// <summary>
    /// 移动速度
    /// </summary>
    public int MoveSpeed;
    
    /// <summary>
    /// 冷却缩减
    /// </summary>
    public int CoolingReduction;
    
    /// <summary>
    /// 伤害加成
    /// </summary>
    public int DamageAdd;
    
    /// <summary>
    /// 伤害减免
    /// </summary>
    public int DamageDf;
    
    /// <summary>
    /// 怪物伤害加成
    /// </summary>
    public int MonsterDamageAdd;
    
    /// <summary>
    /// 怪物伤害减免
    /// </summary>
    public int MonsterDamageDf;
    
    /// <summary>
    /// 怪物金币加成
    /// </summary>
    public int MonsterGoldAdd;
    
    /// <summary>
    /// 怪物经验加成
    /// </summary>
    public int MonsterExpAdd;
    
    /// <summary>
    /// 活动金币加成
    /// </summary>
    public int ActivityGoldAdd;
    
    /// <summary>
    /// 活动经验加成
    /// </summary>
    public int ActivityExpAdd;
    
    public override int GetID()
    {
return ID ;
    }
}
