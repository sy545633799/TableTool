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



public class SkillLevelUpTable : BaseTxtTable<SkillLevelUpTable>
{
    
    public string XlsxMapping = "Skill.xlsx";
    
    /// <summary>
    /// ID
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 长描述
    /// </summary>
    public string LongDescribe;
    
    /// <summary>
    /// 暴击判定
    /// </summary>
    public int Critical;
    
    /// <summary>
    /// 伤害类型
    /// </summary>
    public string HarmType;
    
    /// <summary>
    /// 结算属性对象
    /// </summary>
    public string AttributeObj;
    
    /// <summary>
    /// 结算属性
    /// </summary>
    public string Attribute;
    
    /// <summary>
    /// 万分比下限
    /// </summary>
    public string MinAdd;
    
    /// <summary>
    /// 万分比上限
    /// </summary>
    public string MaxAdd;
    
    /// <summary>
    /// 万分比下限增量
    /// </summary>
    public string MinAddUpgrade;
    
    /// <summary>
    /// 万分比上限增量
    /// </summary>
    public string MaxAddUpgrade;
    
    /// <summary>
    /// 固定初始值下限
    /// </summary>
    public string MinValue;
    
    /// <summary>
    /// 固定初始值上限
    /// </summary>
    public string MaxValue;
    
    /// <summary>
    /// 固定值下限增量
    /// </summary>
    public string MinValueUpgrade;
    
    /// <summary>
    /// 固定值上限增量
    /// </summary>
    public string MaxValueUpgrade;
    
    /// <summary>
    /// 初始仇恨值
    /// </summary>
    public int Hatred;
    
    /// <summary>
    /// 仇恨值每级增加
    /// </summary>
    public int HatredUpgrade;
    
    public override int GetID()
    {
return ID ;
    }
}
