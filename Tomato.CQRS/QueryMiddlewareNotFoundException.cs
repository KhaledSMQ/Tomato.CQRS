﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomato.CQRS
{
    /// <summary>
    /// 查询中间件未找到
    /// </summary>
    public class QueryMiddlewareNotFoundException : Exception
    {
        /// <summary>
        /// 查询链类型
        /// </summary>
        public Type QueryChainType { get; private set; }

        public QueryMiddlewareNotFoundException(Type queryChainType)
            :base(queryChainType.ToString() + " 查询链未找到任何中间件。")
        {
            QueryChainType = queryChainType;
        }
    }
}
