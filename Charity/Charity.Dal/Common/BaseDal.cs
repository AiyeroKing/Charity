using Charity.Model.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Charity.Dal.Common
{
    /// <summary>
    /// 基础dal，用于其他dal的继承基类
    /// </summary>
    public abstract class BaseDal
  {

    /// <summary>
    /// 添加记录
    /// </summary>
    /// <typeparam name="TEntity">实体类</typeparam>
    /// <param name="returnIdentity">是否返回Identity字段，如新增后返回记录Id </param>
    /// <param name="sql">新增的sql语句</param>
    /// <param name="entity"></param>
    /// <param name="trans">是否事务</param>
    /// <returns></returns>
    protected int Add<TEntity>(bool returnIdentity, string sql, TEntity entity, IDbTransaction trans = null) where TEntity : class
    {
      if (returnIdentity)
      {
        return Convert.ToInt32(QuerySingle<decimal>(sql, entity, trans));
      }
      else
      {
        return this.Excute(sql, entity, trans);
      }
    }

    /// <summary>
    /// 实体更新
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="sql">更新的sql</param>
    /// <param name="entity"></param>
    /// <param name="trans">是否启用事务</param>
    /// <returns></returns>
    protected int Update<TEntity>(string sql, TEntity entity, IDbTransaction trans = null) where TEntity : class
    {
      return this.Excute(sql, entity, trans);
    }

    /// <summary>
    /// 根据字典更新表的部分字段，字典的key必须和数据库保持一致
    /// </summary>
    /// <param name="table">表名称</param>
    /// <param name="keyName">主键名称 如Id</param>
    /// <param name="keyValue">主键值</param>
    /// <param name="dic">更新字典</param>
    /// <param name="trans"></param>
    /// <returns></returns>
    protected int Update(string table, string keyName, string keyValue, IDictionary<string, string> dic, IDbTransaction trans = null)
    {
      StringBuilder sql = new StringBuilder();
      sql.AppendFormat(" UPDATE {0} SET ", table);
      DynamicParameters dp = new DynamicParameters();
      foreach (KeyValuePair<string, string> kvp in dic)
      {
        sql.AppendFormat(" {0}=@{0} ,", kvp.Key);
        dp.Add(kvp.Key, kvp.Value);
      }
      sql.Remove(sql.Length - 1, 1);//去除逗号
      sql.AppendFormat(" where {0}=@{0} ", keyName);
      dp.Add(keyName, keyValue);

      return Excute(sql.ToString(), dp, trans);
    }

    /// <summary>
    /// 检查是否存在引用
    /// </summary>
    /// <param name="deleteValue"></param>
    /// <param name="itemByItem">是否逐条进行判断</param>
    /// <param name="refList">ex。 "employee" "departmentId" "员工表"</param>
    /// <returns></returns>
    protected Tuple<bool, string> CanDelete(int deleteValue, bool itemByItem, params Tuple<string, string, string>[] refList)
    {
      const string deleteCheckSql = @" SELECT  1
                                             WHERE   EXISTS ( SELECT 1
                                                             FROM   {0}
                                                             WHERE  {1} = @DeleteValue) ";
      int queryResult = 0;
      if (itemByItem)
      {
        foreach (var refInfo in refList)
        {
          queryResult = this.QuerySingle<int>(
              string.Format(deleteCheckSql, refInfo.Item1, refInfo.Item2), new { DeleteValue = deleteValue });
          if (queryResult > 0)
          {
            return new Tuple<bool, string>(false, refInfo.Item3 + "存在相关引用");
          }
        }
      }
      else
      {
        StringBuilder strBuiler = new StringBuilder();
        foreach (var refInfo in refList)
        {
          if (strBuiler.Length > 0)
          {
            strBuiler.AppendLine(" UNION ");
          }
          strBuiler.AppendLine(string.Format(deleteCheckSql, refInfo.Item1, refInfo.Item2));
        }
        queryResult = this.QuerySingle<int>(
                strBuiler.ToString(), new { DeleteValue = deleteValue });

        if (queryResult > 0)
        {
          return new Tuple<bool, string>(false, "该记录存在相关引用");
        }
      }
      return new Tuple<bool, string>(true, string.Empty);
    }

    protected T GetMax<T>(string tableName, string colName)
    {
      return this.QuerySingle<T>(string.Format("SELECT MAX({0}) FROM {1} WHERE {0} IS NOT NULL ", colName, tableName));
    }

    /// <summary>
    /// 执行Sql
    /// </summary>
    /// <param name="sql">sql</param>
    /// <param name="param">参数</param>
    /// <returns></returns>
    protected int Excute(string sql, object param = null, IDbTransaction trans = null)
    {
      if (trans == null)
      {
        using (DbConnection conn = DbFactory.CreateConnection())
        {
          return conn.Execute(sql, param);
        }
      }
      else
      {
        return trans.Connection.Execute(sql, param, trans);
      }
    }

    /// <summary>
    /// 执行查询Sql并返回实体 可以为Int等struct 或者具体的类实体
    /// </summary>
    /// <typeparam name="T">泛型实体</typeparam>
    /// <param name="sql">sql语句</param>
    /// <param name="param">@参数</param>
    /// <returns></returns>
    protected T QuerySingle<T>(string sql, object param = null, IDbTransaction trans = null)
    {
      return Query<T>(sql, param, trans).SingleOrDefault();
    }

    /// <summary>
    /// 执行查询Sql并返回实体 可以为Int等struct 或者具体的类实体
    /// </summary>
    /// <typeparam name="T">泛型实体</typeparam>
    /// <param name="sql">sql语句</param>
    /// <param name="param">@参数</param>
    /// <returns></returns>
    protected T QueryFirst<T>(string sql, object param = null, IDbTransaction trans = null)
    {
        return Query<T>(sql, param, trans).FirstOrDefault();
    }


    /// <summary>
    /// 执行查询Sql并返回实体 可以为Int等struct 或者具体的类实体
    /// </summary>
    /// <typeparam name="T">泛型实体</typeparam>
    /// <param name="sql">sql</param>
    /// <param name="param">@参数</param>
    /// <returns></returns>
    protected IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction trans = null)
    {
      if (trans == null)
      {
        using (DbConnection conn = DbFactory.CreateConnection())
        {
          return conn.Query<T>(sql, param);
        }
      }
      else
      {
        return trans.Connection.Query<T>(sql, param, trans);
      }
    }

    /// <summary>
    /// 执行Sql
    /// </summary>
    /// <param name="sql">sql</param>
    /// <param name="param">参数</param>
    /// <returns></returns>
    protected int ConnStrTypeExcute(string sql, object param = null, IDbTransaction trans = null)
    {
        if (trans == null)
        {
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                return conn.Execute(sql, param);
            }
        }
        else
        {
            return trans.Connection.Execute(sql, param, trans);
        }
    }

    /// <summary>
    /// 执行查询Sql并返回实体 可以为Int等struct 或者具体的类实体  
    /// </summary>2016-11-16 Add by zyp增加生产数据库访问方法
    /// <typeparam name="T">泛型实体</typeparam>
    /// <param name="sql">sql语句</param>
    /// <param name="param">@参数</param>
    /// <returns></returns>
    protected T ConnStrTypeQuerySingle<T>(string sql, object param = null, IDbTransaction trans = null)
    {
        return ConnStrTypeQuery<T>(sql, param, trans).SingleOrDefault();
    }

    /// <summary>
    /// 执行查询Sql并返回实体 可以为Int等struct 或者具体的类实体
    /// </summary> 2016-11-16 Add by zyp增加生产数据库访问方法
    /// <typeparam name="T">泛型实体</typeparam>
    /// <param name="sql">sql</param>
    /// <param name="param">@参数</param>
    /// <returns></returns>
    protected IEnumerable<T> ConnStrTypeQuery<T>(string sql, object param = null, IDbTransaction trans = null)
    {
        if (trans == null)
        {
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                return conn.Query<T>(sql, param);
            }
        }
        else
        {
            return trans.Connection.Query<T>(sql, param, trans);
        }
    }

    /// <summary>
    /// 分页查询Sql并返回实体 T可以为Int等struct 或者具体的类实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">sql</param>
    /// <param name="total">总条数</param>
    /// <param name="param">参数</param>
    /// <returns></returns>
    protected IEnumerable<T> QueryPage<T>(string sql, out int total, object param = null)
    {
      using (DbConnection conn = DbFactory.CreateConnection())
      {
        var result = conn.QueryMultiple(sql, param);
        total = result.Read<int>().SingleOrDefault();
        var data = result.Read<T>();
        return data;
      }
    }

    /// <summary>
    /// 分页查询Sql并返回实体 T可以为Int等struct 或者具体的类实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">sql</param>
    /// <param name="total">总条数</param>
    /// <param name="param">参数</param>
    /// <returns></returns>
    protected PagerResult<T> QueryPage<T>(string sql, object param = null)
    {
      using (DbConnection conn = DbFactory.CreateConnection())
      {
        var result = conn.QueryMultiple(sql, param);
        int total = result.Read<int>().SingleOrDefault();
        var data = result.Read<T>();
        return new PagerResult<T>(data, total);
      }
    }


    /// </param>
    /// <returns>
    /// Dapper.SqlMapper.GridReader。
    /// </returns>
    protected SqlMapper.GridReader QueryMultiple(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
    {
      if (transaction == null)
      {
        //using (
        IDbConnection conn = DbFactory.CreateConnection();
        //  )
        //{
        var result = conn.QueryMultiple(sql, param, transaction, commandTimeout, commandType);
        return result;
        //}
      }
      else
      {
        return transaction.Connection.QueryMultiple(sql, param, transaction, commandTimeout, commandType);
      }
    }
    
  }
}
