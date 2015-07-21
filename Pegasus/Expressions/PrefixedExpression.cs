﻿// -----------------------------------------------------------------------
// <copyright file="PrefixedExpression.cs" company="(none)">
//   Copyright © 2015 John Gietzen.  All Rights Reserved.
//   This source is subject to the MIT license.
//   Please see license.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Pegasus.Expressions
{
    /// <summary>
    /// Represents an expression that has been given a name as a prefix.
    /// </summary>
    public class PrefixedExpression : Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixedExpression"/> class.
        /// </summary>
        /// <param name="prefix">The name given to this expression as a prefix.</param>
        /// <param name="expression">The expression that has been prefixed.</param>
        public PrefixedExpression(Identifier prefix, Expression expression)
        {
            this.Prefix = prefix;
            this.Expression = expression;
        }

        /// <summary>
        /// Gets the expression that has been prefixed.
        /// </summary>
        public Expression Expression { get; }

        /// <summary>
        /// Gets the name given to this expression as a prefix.
        /// </summary>
        public Identifier Prefix { get; }
    }
}
