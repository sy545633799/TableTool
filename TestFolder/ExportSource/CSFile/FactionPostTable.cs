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



public class FactionPostTable : BaseTxtTable<FactionPostTable>
{
    
    public string XlsxMapping = "Faction.xlsx";
    
    /// <summary>
    /// 职位ID
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 默认职位名称
    /// </summary>
    public string Name;
    
    /// <summary>
    /// 数量
    /// </summary>
    public int Count;
    
    /// <summary>
    /// 权限
    /// </summary>
    public string Item;
    
    /// <summary>
    /// 职位图标
    /// </summary>
    public string Icon;
    
    public override int GetID()
    {
return ID ;
    }
}