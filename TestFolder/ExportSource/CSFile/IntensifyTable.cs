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



public class IntensifyTable : BaseTxtTable<IntensifyTable>
{
    
    public string XlsxMapping = "Intensify.xlsx";
    
    /// <summary>
    /// 强化等级
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 强化基础概率
    /// </summary>
    public int Probability;
    
    /// <summary>
    /// 失败附加概率
    /// </summary>
    public int FailureAdd;
    
    /// <summary>
    /// 强化物品消耗
    /// </summary>
    public string Consume;
    
    /// <summary>
    /// 强化银币消耗
    /// </summary>
    public int count;
    
    /// <summary>
    /// 强化属性百分比
    /// </summary>
    public int Property;
    
    /// <summary>
    /// 强化公告
    /// </summary>
    public int AnnouncementId;
    
    public override int GetID()
    {
return ID ;
    }
}
