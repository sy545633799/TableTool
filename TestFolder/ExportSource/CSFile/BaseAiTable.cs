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



public class BaseAiTable : BaseTxtTable<BaseAiTable>
{
    
    public string XlsxMapping = "BaseAi.xlsx";
    
    /// <summary>
    /// 索引
    /// </summary>
    public int BaseID;
    
    /// <summary>
    /// AI响应时间系数
    /// </summary>
    public int Response;
    
    /// <summary>
    /// 警戒范围
    /// </summary>
    public int ActiveAttackRange;
    
    /// <summary>
    /// 搜索目标类型
    /// </summary>
    public int TargetType;
    
    /// <summary>
    /// 呼叫同伴范围
    /// </summary>
    public int Callpartner;
    
    /// <summary>
    /// 是否还击
    /// </summary>
    public int Fight;
    
    /// <summary>
    /// 追击范围
    /// </summary>
    public int ChaseRange;
    
    /// <summary>
    /// 是否回到出生点
    /// </summary>
    public int Reset;
    
    /// <summary>
    /// 追击返回是否无敌
    /// </summary>
    public int Invincible;
    
    /// <summary>
    /// 脱战回血
    /// </summary>
    public int RecoverHp;
    
    /// <summary>
    /// 活动方式
    /// </summary>
    public int ActMode;
    
    /// <summary>
    /// 跟随
    /// </summary>
    public int Follow;
    
    public override int GetID()
    {
return BaseID ;
    }
}
