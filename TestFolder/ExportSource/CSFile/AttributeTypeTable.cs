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



public class AttributeTypeTable : BaseTxtTable<AttributeTypeTable>
{
    
    public string XlsxMapping = "Actor.xlsx";
    
    /// <summary>
    /// ID
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 属性名称
    /// </summary>
    public string Effect;
    
    /// <summary>
    /// 战力系数
    /// </summary>
    public int FightRatio;
    
    /// <summary>
    /// 界面显示
    /// </summary>
    public string Interface;
    
    /// <summary>
    /// 属性描述
    /// </summary>
    public string Dec;
    
    /// <summary>
    /// 显示
    /// </summary>
    public int Xianshi;
    
    /// <summary>
    /// 属性生效上限
    /// </summary>
    public int upperlimit;
    
    public override int GetID()
    {
return ID ;
    }
}