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



public class SkillGroupTable : BaseTxtTable<SkillGroupTable>
{
    
    public string XlsxMapping = "Slot.xlsx";
    
    /// <summary>
    /// 组合ID
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 职业
    /// </summary>
    public int Job;
    
    /// <summary>
    /// 组合名称
    /// </summary>
    public string Name;
    
    /// <summary>
    /// 组合说明
    /// </summary>
    public string Dec;
    
    /// <summary>
    /// 组合内的技能
    /// </summary>
    public string GroupSkill;
    
    /// <summary>
    /// 解锁等级
    /// </summary>
    public int Level;
    
    public override int GetID()
    {
return ID ;
    }
}
