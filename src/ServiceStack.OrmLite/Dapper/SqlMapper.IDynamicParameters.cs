﻿using System.Data;

//Apache 2.0 License: https://github.com/StackExchange/dapper-dot-net/blob/master/License.txt
namespace ServiceStack.OrmLite.Dapper
{
    partial class SqlMapper
    {
        /// <summary>
        /// Implement this interface to pass an arbitrary db specific set of parameters to Dapper
        /// </summary>
        public interface IDynamicParameters
        {
            /// <summary>
            /// Add all the parameters needed to the command just before it executes
            /// </summary>
            /// <param name="command">The raw command prior to execution</param>
            /// <param name="identity">Information about the query</param>
            void AddParameters(IDbCommand command, Identity identity);
        }
    }
}