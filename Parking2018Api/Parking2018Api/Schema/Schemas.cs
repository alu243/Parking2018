using GraphQL.Net;
using GraphQL.Types;
using Parking2018Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking2018Api.EF
{
    public class Schemas
    {
        public GraphQLSchema BillSchema()
        {
            var schema = GraphQL<KHParkContext>.CreateDefaultSchema(() => new KHParkContext());
            schema.AddType<M_BILL>().AddAllFields();
            schema.AddListField("M_BILL_RECS", db => db.M_BILL_REC);
            return schema;
            //user.AddField(u => u.Id);
            //user.AddField(u => u.Name);
            //user.AddField(u => u.Account);
            //user.AddField("totalUsers", (db, u) => db.Users.Count());
            //user.AddField("accountPaid", (db, u) => u.Account.Paid);
        }
    }

    //public class BillSchema : Schema
    //{
    //   public BillSchema(Func<Type, GraphType> resolveType) :base(resolveType)
    //    {
    //        Query = (BillQuery)resolveType(typeof(BillQuery));
    //    }
    //}
}
