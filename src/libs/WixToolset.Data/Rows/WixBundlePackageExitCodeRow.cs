﻿//-------------------------------------------------------------------------------------------------
// <copyright file="WixBundlePackageExitCodeRow.cs" company="Outercurve Foundation">
//   Copyright (c) 2004, Outercurve Foundation.
//   This software is released under Microsoft Reciprocal License (MS-RL).
//   The license and further copyright text can be found in the file
//   LICENSE.TXT at the root directory of the distribution.
// </copyright>
//-------------------------------------------------------------------------------------------------

namespace WixToolset.Data.Rows
{
    /// <summary>
    /// Specialization of a row for the ExitCode table.
    /// </summary>
    public class WixBundlePackageExitCodeRow : Row
    {
        /// <summary>
        /// Creates a ExitCodeRow row that does not belong to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="tableDef">TableDefinition this Media row belongs to and should get its column definitions from.</param>
        public WixBundlePackageExitCodeRow(SourceLineNumber sourceLineNumbers, TableDefinition tableDef) :
            base(sourceLineNumbers, tableDef)
        {
        }

        /// <summary>
        /// Creates a ExitCodeRow row that belongs to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="table">Table this Media row belongs to and should get its column definitions from.</param>
        public WixBundlePackageExitCodeRow(SourceLineNumber sourceLineNumbers, Table table) :
            base(sourceLineNumbers, table)
        {
        }

        /// <summary>
        /// Gets or sets the foreign key identifier to the ChainPackage row.
        /// </summary>
        public string ChainPackageId
        {
            get { return (string)this.Fields[0].Data; }
            set { this.Fields[0].Data = value; }
        }

        public int? Code
        {
            get { return (null == this.Fields[1].Data) ? (int?)null : (int?)this.Fields[1].Data; }
            set { this.Fields[1].Data = value; }
        }

        public ExitCodeBehaviorType Behavior
        {
            get { return (ExitCodeBehaviorType)this.Fields[2].Data; }
            set { this.Fields[2].Data = (int)value; }
        }
    }
}
