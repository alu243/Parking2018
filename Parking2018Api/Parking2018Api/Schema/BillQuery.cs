using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking2018Api.EF
{
    public class BillQuery : ObjectGraphType
    {
        public BillQuery(string query)
        {
            //Field<ListGraphType<>>
            // 資料回傳型別
            Field<ListGraphType<CaptionType>>(
              "captions", // 查詢命令的名稱
             arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Category id" }
               ),// 查詢參數
              resolve: context => { ... } // 準備回傳資料
        }
    }
}
