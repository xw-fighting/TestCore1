using Dream.EntityFrameworkCore;
using Dream.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dream.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private BaseDbContext db;
        public DbSet<TEntity> _dbSet;

        public BaseRepository(BaseDbContext dbContext)
        {
            db = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        

      
        //查询
        #region 2.0  查询相关方法

        /// <summary>
        /// 根据labmda表达式进行查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<TEntity> QueryWhere(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public IQueryable<TEntity> QueryWhereToModel(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where<TEntity>(where);
        }


        /// <summary>
        /// 连表操作
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableNames"></param>
        /// <returns></returns>
        public List<TEntity> QueryJoin(Expression<Func<TEntity, bool>> where, string[] tableNames)
        {
            if (tableNames == null || tableNames.Any() == false)
            {
                throw new Exception("连表操作的表名称至少要有一个");
            }

            //DbQuery<TEntity> query = _dbSet;
            IQueryable<TEntity> query = _dbSet;
            foreach (var tablename in tableNames)
            {
                query = query.Include(tablename);
            }

            return query.Where(where).ToList();

            //return _dbSet.Include("A").Include("B")
        }

        /// <summary>
        /// 按照条件查询出数据以后，根据外部指定的字段进行升序排列
        /// </summary>
        /// <typeparam name="TKey">表示从Tentity中获取的属性类型</typeparam>
        /// <param name="where">条件</param>
        /// <param name="order">排序lambda表达式</param>
        /// <returns></returns>
        public List<TEntity> QueryOrderBy<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order)
        {
            return _dbSet.Where(where).OrderBy(order).ToList();
        }

        /// <summary>
        /// 按照条件查询出数据以后，根据外部指定的字段进行倒序排列
        /// </summary>
        /// <typeparam name="TKey">表示从Tentity中获取的属性类型</typeparam>
        /// <param name="where">条件</param>
        /// <param name="order">排序lambda表达式</param>
        /// <returns></returns>
        public List<TEntity> QueryOrderByDescending<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order)
        {
            return _dbSet.Where(where).OrderByDescending(order).ToList();
        }

        /// <summary>
        /// 分页方法
        /// </summary>
        /// <typeparam name="TKey">要指定的排序属性名称 Tentity.property</typeparam>
        /// <param name="pageindex">分页页码</param>
        /// <param name="pagesize">页容量</param>
        /// <param name="rowcount">总行数</param>
        /// <param name="order">排序lambda表达式</param>
        /// <param name="where">查询条件lambda表达式</param>
        /// <returns></returns>
        public List<TEntity> QueryByPage<TKey>(int pageindex, int pagesize, out int rowcount, Expression<Func<TEntity, TKey>> order, Expression<Func<TEntity, bool>> where)
        {
            //1.0 计算当前分页要跳过的数据行数
            int skipCount = (pageindex - 1) * pagesize;

            //2.0 获取当前满足条件的所有数据总条数
            rowcount = _dbSet.Count(where);

            //3.0 获取分页数据
            return _dbSet.Where(where).OrderByDescending(order).Skip(skipCount).Take(pagesize).ToList();
        }

        #endregion

        //修改
        #region 3.0  编辑相关方法

        public void Edit(TEntity model, string[] propertys)
        {
            if (model == null)
            {
                throw new Exception("实体不能为空");
            }

            if (propertys.Any() == false)
            {
                throw new Exception("要修改的属性至少要有一个");
            }

            //2.0 将model追击到EF容器
            //System.Data.Entity.Infrastructure.DbEntityEntry entry = db.Entry(model);
            var entry = db.Entry(model);
            entry.State = EntityState.Modified;

            foreach (var item in propertys)
            {
                entry.Property(item).IsModified = true;
            }

            //3.0 关闭EF对于实体的合法性验证参数
            //db.Configuration.ValidateOnSaveEnabled = false;
        }

        #endregion
        //删除
        #region 4.0  删除相关方法

        public void Delete(TEntity model, bool isadded)
        {
            //(!isadded)表示当前model没有追加到EF容器中
            if (!isadded)
            {
                _dbSet.Attach(model);
            }
            _dbSet.Remove(model);
        }
        #endregion
        //添加
        #region 5.0 添加
        //添加
        public void Add(TEntity model)
        {
            _dbSet.Add(model);
        }
        #endregion

        #region 调用存储过程的方法
        /// <summary>
        /// 调用存储过程返回一个自己指定的类型TResult
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sql">存储过程的名字</param>
        /// <param name="parms">存储过程里面的参数</param>
        /// <returns></returns>
        public List<TResult> RunProduce<TResult>(string sql, params object[] parms) where TResult : class
        {
            return db.Set<TResult>().FromSql(sql,parms).ToList();
        }

        #endregion





        //统一提交
        #region 6.0统一提交哦
        public int SaveChange()
        {
            return db.SaveChanges();
        }
        #endregion
    }
}
